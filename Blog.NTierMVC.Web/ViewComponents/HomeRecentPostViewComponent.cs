using Blog.NTierMVC.Service.Service.Abstractions;
using Blog.NTierMVC.Service.Service.Concretes;
using Microsoft.AspNetCore.Mvc;

namespace Blog.NTierMVC.Web.ViewComponents
{
    public class HomeRecentPostViewComponent : ViewComponent
    {
        private readonly IArticleService articleService;

        public HomeRecentPostViewComponent(IArticleService articleService)
        {
            this.articleService = articleService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
         
            var articles = await articleService.GetAllArticlesWithCategoryNonDeletedAsync();

            var sortedLast3Article = articles.OrderBy(x => x.CreatedDate).Take(3).ToList();

            return View(sortedLast3Article);
        }
    }
}
