using Blog.NTierMVC.Service.Service.Abstractions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Blog.NTierMVC.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize]
    public class HomeController : Controller
    {
        private readonly IArticleService articleService;
        private readonly IDashboardService dashboardService;

        public HomeController(IArticleService articleService, IDashboardService dashboardService)
        {
            this.articleService = articleService;
            this.dashboardService = dashboardService;
        }
        public async Task<IActionResult> Index()
        {
            var articles = await articleService.GetAllArticlesWithCategoryNonDeletedAsync();
            return View(articles);
        }

        [HttpGet]
        public async Task<IActionResult> YearlyArticleCount()
        {

            var result = await dashboardService.GetYearlyArticleCount();

            return Json(JsonConvert.SerializeObject(result));
        }
    }
}
