using AutoMapper;
using Blog.NTierMVC.Data.UnitOfWorks;
using Blog.NTierMVC.Entity.DTOs.Articles;
using Blog.NTierMVC.Entity.DTOs.Categories;
using Blog.NTierMVC.Entity.Entities;
using Blog.NTierMVC.Service.Service.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.NTierMVC.Service.Service.Concretes
{
    public class CategoryService : ICategoryService
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper mapper;

        public CategoryService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
        }
        public async Task<List<CategoryDto>> GetAllCategoriesNonDeleted()
        {
            var categories = await unitOfWork.GetRepository<Category>().GetAllAsync(x => !x.IsDeleted);
            var map = mapper.Map<List<CategoryDto>>(categories);

            return map;
        }
    }
}
