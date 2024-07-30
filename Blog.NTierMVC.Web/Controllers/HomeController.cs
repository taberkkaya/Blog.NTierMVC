using Blog.NTierMVC.Data.UnitOfWorks;
using Blog.NTierMVC.Entity.DTOs.Articles;
using Blog.NTierMVC.Service.Service.Abstractions;
using Blog.NTierMVC.Web.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding.Metadata;
using System.Diagnostics;

namespace Blog.NTierMVC.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IArticleService articleService;

        public HomeController(ILogger<HomeController> logger,IArticleService articleService)
        {
            _logger = logger;
            this.articleService = articleService;
        }

        public async Task<IActionResult> Index(Guid? categoryId, int currentPage = 1, int pageSize = 3, bool isAscending = false)
        {
            var articles = await articleService.GetAllByPagingAsync(categoryId,currentPage,pageSize,isAscending);
            return View(articles);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public async Task<IActionResult> Detail(Guid id)
        {
            ArticleDto article = await articleService.GetArticleWithCategoryNonDeletedAsync(id);
            
            return View(article);
        }

    }
}
