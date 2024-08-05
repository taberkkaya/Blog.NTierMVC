using Blog.NTierMVC.Service.Service.Abstractions;
using Microsoft.AspNetCore.Mvc;

namespace Blog.NTierMVC.Web.ViewComponents
{
    public class LayoutHeaderSocialMediaViewComponent : ViewComponent
    {
        private readonly ISocialMediaService mediaService;

        public LayoutHeaderSocialMediaViewComponent(ISocialMediaService mediaService)
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
