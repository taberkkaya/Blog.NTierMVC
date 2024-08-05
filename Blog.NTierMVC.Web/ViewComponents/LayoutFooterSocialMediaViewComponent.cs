using Blog.NTierMVC.Service.Service.Abstractions;
using Microsoft.AspNetCore.Mvc;

namespace Blog.NTierMVC.Web.ViewComponents
{
    public class LayoutFooterSocialMediaViewComponent : ViewComponent
    {
        private readonly ISocialMediaService mediaService;

        public LayoutFooterSocialMediaViewComponent(ISocialMediaService mediaService)
        {
            this.mediaService = mediaService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var socialMedias = await mediaService.GetAllSocialMediasNonDeleted();
            return View(socialMedias);
        }
    }
}
