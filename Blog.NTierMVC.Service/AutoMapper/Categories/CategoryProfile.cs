using AutoMapper;
using Blog.NTierMVC.Entity.DTOs.Categories;
using Blog.NTierMVC.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Blog.NTierMVC.Service.AutoMapper.Categories
{
    public class CategoryProfile : Profile
    {
        public CategoryProfile()
        {
            CreateMap<CategoryDto, Category>().ReverseMap();
        }
    }
}
