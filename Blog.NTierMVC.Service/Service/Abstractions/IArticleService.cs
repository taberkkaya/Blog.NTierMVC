using Blog.NTierMVC.Entity.DTOs.Articles;

namespace Blog.NTierMVC.Service.Service.Abstractions
{
    public interface IArticleService
    {
        Task<List<ArticleDto>> GetAllArticlesWithCategoryNonDeletedAsync();
        Task<ArticleDto> GetArticleWithCategoryNonDeletedAsync(Guid articleId);
        Task CreateArticleAsync(ArticleAddDto articleAddDto);
        Task UpdateArticleAsync(ArticleUpdateDto articleUpdateDto);

        Task SafeDeleteArticleAsync(Guid articleId);
    }
}
