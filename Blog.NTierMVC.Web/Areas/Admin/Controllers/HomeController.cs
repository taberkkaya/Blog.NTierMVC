using Blog.NTierMVC.Service.Service.Abstractions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;
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

        [HttpGet]
        public async Task<IActionResult> TotalArticleCount()
        {
            var result = await dashboardService.GetTotalArticleCount();

            return Json(result);
        }

        [HttpGet]
        public async Task<IActionResult> TotalCategoryCount()
        {
            var result = await dashboardService.GetTotalCategoryCount();

            return Json(result);
        }

        [HttpGet]
        public async Task<IActionResult> TotalUserCount()
        {
            var result = await dashboardService.GetTotalUserCount();
            return Json(result);    
        }

        [HttpGet]
        public async Task<IActionResult> TotalRoleCount()
        {
            var result = await dashboardService.GetTotalRoleCount();
            return Json(result);
        }

    }
}
