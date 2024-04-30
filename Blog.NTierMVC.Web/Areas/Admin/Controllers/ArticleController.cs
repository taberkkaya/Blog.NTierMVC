using AutoMapper;
using Blog.NTierMVC.Entity.DTOs.Articles;
using Blog.NTierMVC.Entity.Entities;
using Blog.NTierMVC.Service.Extensions;
using Blog.NTierMVC.Service.Service.Abstractions;
using FluentValidation;
using Microsoft.AspNetCore.Mvc;

namespace Blog.NTierMVC.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ArticleController : Controller
    {
        private readonly IArticleService articleService;
        private readonly ICategoryService categoryService;
        private readonly IMapper mapper;
        private readonly IValidator<Article> validator;

        public ArticleController(IArticleService articleService, ICategoryService categoryService, IMapper mapper, IValidator<Article> validator)
        {
            this.articleService = articleService;
            this.categoryService = categoryService;
            this.mapper = mapper;
            this.validator = validator;
        }
        public async Task<IActionResult> Index()
        {
            var articles = await articleService.GetAllArticlesWithCategoryNonDeletedAsync();
            return View(articles);
        }

        [HttpGet]
        public async Task<IActionResult> Add()
        {
            var categories = await categoryService.GetAllCategoriesNonDeleted();
            return View(new ArticleAddDto { Categories = categories });
        }

        [HttpPost]
        public async Task<IActionResult> Add(ArticleAddDto articleAddDto)
        {
            var map = mapper.Map<Article>(articleAddDto);
            var result = await validator.ValidateAsync(map);

            if (result.IsValid)
            {
                await articleService.CreateArticleAsync(articleAddDto);
                return RedirectToAction("Index", "Article", new { Area = "Admin" });
            }
            else
            {
                var categories = await categoryService.GetAllCategoriesNonDeleted();
                result.AddToModelState(this.ModelState);
                return View(new ArticleAddDto { Categories = categories });
            }
        }

        [HttpGet]
        public async Task<IActionResult> Update(Guid articleId)
        {
            var article = await articleService.GetArticleWithCategoryNonDeletedAsync(articleId);

            var categories = await categoryService.GetAllCategoriesNonDeleted();

            var articleUpdateDto = mapper.Map<ArticleUpdateDto>(article);

            articleUpdateDto.Categories = categories;

            return View(articleUpdateDto);
        }

        [HttpPost]
        public async Task<IActionResult> Update(ArticleUpdateDto articleUpdateDto)
        {
            var map = mapper.Map<Article>(articleUpdateDto);
            var result = await validator.ValidateAsync(map);

            if (result.IsValid)
            {
                await articleService.UpdateArticleAsync(articleUpdateDto);
            }
            else
            {
                result.AddToModelState(this.ModelState);
            }

            var categories = await categoryService.GetAllCategoriesNonDeleted();

            articleUpdateDto.Categories = categories;

            return View(articleUpdateDto);

        }

        public async Task<IActionResult> Delete(Guid articleId)
        {
            await articleService.SafeDeleteArticleAsync(articleId);

            return RedirectToAction("Index", "Article", new { Area = "Admin" });

        }
    }

}
