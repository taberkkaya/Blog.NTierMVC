using Blog.NTierMVC.Entity.DTOs.Categories;
using Blog.NTierMVC.Entity.Entities;

namespace Blog.NTierMVC.Service.Service.Abstractions
{
    public interface ICategoryService
    {
        public Task<List<CategoryDto>> GetAllCategoriesNonDeleted();
        public Task<List<CategoryDto>> GetAllCategoriesDeleted();
        Task CreateCategoryAsync(CategoryAddDto categoryAddDto);
        Task<Category> GetCategoryByGuid(Guid id);
        Task<string> UpdateCategoryAsync(CategoryUpdateDto categoryUpdateDto);
        Task<string> SafeDeleteCategoryAsync(Guid categoryId);
        Task<string> UndoDeleteCategoryAsync(Guid categoryId);

    }
}
