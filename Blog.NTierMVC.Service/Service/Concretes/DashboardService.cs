using Blog.NTierMVC.Data.UnitOfWorks;
using Blog.NTierMVC.Entity.Entities;
using Blog.NTierMVC.Service.Service.Abstractions;

namespace Blog.NTierMVC.Service.Service.Concretes
{
    public class DashboardService : IDashboardService
    {
        private readonly IUnitOfWork unitOfWork;

        public DashboardService(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public async Task<int> GetTotalArticleCount()
        {
            var countArticle = await unitOfWork.GetRepository<Article>().CountAsync();

            return countArticle;
        }

        public async Task<int> GetTotalCategoryCount()
        {
            var countCategory = await unitOfWork.GetRepository<Category>().CountAsync();

            return countCategory;
        }

        public async Task<List<int>> GetYearlyArticleCount()
        {
            var articles = await unitOfWork.GetRepository<Article>().GetAllAsync(x => !x.IsDeleted);

            var startDate = DateTime.Now;

            startDate = new DateTime(startDate.Year, 1, 1);

            List<int> datas = new();

            for(int i = 1; i <= 12; i++)
            {
                var startedDate = new DateTime(startDate.Year, i, 1);
                var endedDate = startedDate.AddMonths(1);
                var data = articles.Where(x => x.CreatedDate >= startedDate && x.CreatedDate < endedDate).Count();
                datas.Add(data);
            }

            return datas;
        }
    }
}
