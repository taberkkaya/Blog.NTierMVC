namespace Blog.NTierMVC.Service.Service.Abstractions
{
    public interface IDashboardService
    {
        Task<List<int>> GetYearlyArticleCount();
    }
}
