using Blog.NTierMVC.Data.UnitOfWorks;
using Blog.NTierMVC.Entity.Entities;
using Blog.NTierMVC.Service.Service.Abstractions;
using Blog.NTierMVC.Service.Service.Concretes;
using Blog.NTierMVC.Web.Const;
using Blog.NTierMVC.Web.ResultMessages;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using NToastNotify;

namespace Blog.NTierMVC.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize]
    public class SocialMediaController : Controller
    {
        private readonly ISocialMediaService socialMediaService;
        private readonly IUnitOfWork unitOfWork;

        public SocialMediaController(ISocialMediaService socialMediaService, IUnitOfWork unitOfWork)
        {
            this.socialMediaService = socialMediaService;
            this.unitOfWork = unitOfWork;
        }

        [HttpGet]
        [Authorize(Roles = $"{RoleConsts.Superadmin},{RoleConsts.Admin},{RoleConsts.User}")]
        public IActionResult Index()
        {
            var socialMedias = socialMediaService.GetAllSocialMediasNonDeleted().Result;
            return View(socialMedias);
        }

        [HttpGet]
        [Authorize(Roles = $"{RoleConsts.Superadmin},{RoleConsts.Admin},{RoleConsts.User}")]
        public async Task<IActionResult> Update(Guid socialMediaId)
        {
            var socialMedia = await unitOfWork.GetRepository<SocialMedia>().GetByGuidAsync(socialMediaId);
            return View(socialMedia);
        }

        [HttpPost]
        public async Task<IActionResult> Update(SocialMedia socialMedia)
        {
            var social = await unitOfWork.GetRepository<SocialMedia>().GetByGuidAsync(socialMedia.Id);

            social.Name = socialMedia.Name;
            social.Url = socialMedia.Url;
            social.Icon = socialMedia.Icon;

            await unitOfWork.GetRepository<SocialMedia>().UpdateAsync(social);
            await unitOfWork.SaveAsync();

            return View();
        }

        public async Task<IActionResult> Delete(Guid socialMediaId)
        {
            var name = await socialMediaService.SafeDeleteSocialMediaAsync(socialMediaId);
            //toast.AddSuccessToastMessage(Messages.Category.SafeDelete(name), new ToastrOptions() { Title = "Silindi!" });
            return RedirectToAction("Index", "SocialMedia", new { Area = "Admin" });

        }


        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> Add(SocialMedia socialMedia)
        {
            await socialMediaService.Add(socialMedia);

            return RedirectToAction("Index", "SocialMedia", new { Area = "Admin" });
        }

    }
}
