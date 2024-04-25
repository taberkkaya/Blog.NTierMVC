using Blog.NTierMVC.Entity.DTOs.Categories;

namespace Blog.NTierMVC.Service.Service.Abstractions
{
    public interface ICategoryService
    {
        public Task<List<CategoryDto>> GetAllCategoriesNonDeleted();

    }
}
