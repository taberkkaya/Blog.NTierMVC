﻿using AutoMapper;
using Blog.NTierMVC.Entity.DTOs.Categories;
using Blog.NTierMVC.Entity.Entities;
using Blog.NTierMVC.Service.Extensions;
using Blog.NTierMVC.Service.Service.Abstractions;
using Blog.NTierMVC.Service.Service.Concretes;
using Blog.NTierMVC.Web.ResultMessages;
using FluentValidation;
using Microsoft.AspNetCore.Mvc;
using NToastNotify;
using System.Reflection;

namespace Blog.NTierMVC.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CategoryController : Controller
    {
        private readonly ICategoryService categoryService;
        private readonly IValidator<Category> validator;
        private readonly IMapper mapper;
        private readonly IToastNotification toast;

        public CategoryController(ICategoryService categoryService, IValidator<Category> validator, IMapper mapper, IToastNotification toast)
        {
            this.categoryService = categoryService;
            this.validator = validator;
            this.mapper = mapper;
            this.toast = toast;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var categories = await categoryService.GetAllCategoriesNonDeleted();
            return View(categories);
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Add(CategoryAddDto categoryAddDto)
        {
            var map = mapper.Map<Category>(categoryAddDto);
            var result = await validator.ValidateAsync(map);

            if (result.IsValid)
            {
                await categoryService.CreateCategoryAsync(categoryAddDto);

                toast.AddSuccessToastMessage(Messages.Category.Add(categoryAddDto.Name));

                return RedirectToAction("Index", "Category", new { Area = "Admin" });
            }

            result.AddToModelState(this.ModelState);
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddWithAjax([FromBody] CategoryAddDto categoryAddDto)
        {
            var map = mapper.Map<Category>(categoryAddDto);
            var result = await validator.ValidateAsync(map);

            if (result.IsValid)
            {
                await categoryService.CreateCategoryAsync(categoryAddDto);

                toast.AddSuccessToastMessage(Messages.Category.Add(categoryAddDto.Name));

                return Json(Messages.Category.Add(categoryAddDto.Name));
            }
            else
            {
                toast.AddErrorToastMessage(result.Errors.First().ErrorMessage, new ToastrOptions
                {
                    Title = "Operation Failed"
                });

                return Json(result.Errors.First().ErrorMessage);
            }
        }


        [HttpGet]
        public async Task<IActionResult> Update(Guid categoryId)
        {
            var category = await categoryService.GetCategoryByGuid(categoryId);
            var map = mapper.Map<CategoryUpdateDto>(category);
            return View(map);
        }

        [HttpPost]
        public async Task<IActionResult> Update(CategoryUpdateDto categoryUpdateDto)
        {
            var map = mapper.Map<Category>(categoryUpdateDto);
            var result = await validator.ValidateAsync(map);

            if (result.IsValid)
            {
                var name = await categoryService.UpdateCategoryAsync(categoryUpdateDto);
                toast.AddSuccessToastMessage(Messages.Category.Update(name));
                return RedirectToAction("Index", "Category", new { Area = "Admin" });
            }

            result.AddToModelState(this.ModelState);
            return View();
        }

        public async Task<IActionResult> Delete(Guid categoryId)
        {
            var name = await categoryService.SafeDeleteCategoryAsync(categoryId);
            toast.AddSuccessToastMessage(Messages.Category.SafeDelete(name), new ToastrOptions() { Title = "Silindi!" });
            return RedirectToAction("Index", "Category", new { Area = "Admin" });

        }

        [HttpGet]
        public async Task<IActionResult> UndoDelete(Guid categoryId)
        {
            var name = await categoryService.UndoDeleteCategoryAsync(categoryId);
            toast.AddSuccessToastMessage(Messages.Category.UndoDelete(name), new ToastrOptions() { Title = "Başırlı!" });
            return RedirectToAction("Index", "Category", new { Area = "Admin" });

        }

        [HttpGet]
        public async Task<IActionResult> DeletedCategory()
        {
            var categories = await categoryService.GetAllCategoriesDeleted();
            return View(categories);
        }

    }
}
