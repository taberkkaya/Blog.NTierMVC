﻿using Blog.NTierMVC.Service.Service.Abstractions;
using Microsoft.AspNetCore.Mvc;

namespace Blog.NTierMVC.Web.ViewComponents
{
    public class HomeCategoriesViewComponent : ViewComponent
    {
        private readonly ICategoryService categoryService;

        public HomeCategoriesViewComponent(ICategoryService categoryService)
        {
            this.categoryService = categoryService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var categories = await categoryService.GetAllCategoriesNonDeletedTake24();

            return View(categories);
        }
    }
}
