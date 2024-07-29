using AutoMapper;
using Blog.NTierMVC.Data.UnitOfWorks;
using Blog.NTierMVC.Entity.DTOs.Articles;
using Blog.NTierMVC.Entity.DTOs.Image;
using Blog.NTierMVC.Entity.Entities;
using Blog.NTierMVC.Entity.Enums;
using Blog.NTierMVC.Service.Extensions;
using Blog.NTierMVC.Service.Helpers.Images;
using Blog.NTierMVC.Service.Service.Abstractions;
using Microsoft.AspNetCore.Http;
using System.Net.Mime;
using System.Security.Claims;

namespace Blog.NTierMVC.Service.Service.Concretes
{
    public class ArticleService : IArticleService
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper mapper;
        private readonly IHttpContextAccessor httpContextAccessor;
        private readonly IImageHelper imageHelper;
        private readonly ClaimsPrincipal _user;

        public ArticleService(IUnitOfWork unitOfWork, IMapper mapper, IHttpContextAccessor httpContextAccessor, IImageHelper imageHelper)
        {
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
            this.httpContextAccessor = httpContextAccessor;
            this.imageHelper = imageHelper;
            _user = httpContextAccessor.HttpContext.User;
        }

        public async Task<ArticleListDto> GetAllByPagingAsync(Guid? categoryId, int currentPage = 1, int pageSize = 1, bool isAscending = false)
        {
            pageSize = pageSize > 20 ? 20 : pageSize;

            var articles = categoryId == null ?
                await unitOfWork.GetRepository<Article>().GetAllAsync(a => !a.IsDeleted, a => a.Category, a => a.Image, u => u.User)
                : await unitOfWork.GetRepository<Article>().GetAllAsync(a => a.CategoryId == categoryId && !a.IsDeleted, x => x.Category, i => i.Image, u => u.User);

            var sortedArtciles = isAscending ?
                articles.OrderBy(x => x.CreatedDate).Skip((currentPage - 1) * pageSize).Take(pageSize).ToList() 
                : articles.OrderByDescending(x => x.CreatedDate).Skip((currentPage - 1) * pageSize).Take(pageSize).ToList();

            //var map = mapper.Map<List<ArticleListDto>>(articles);

            return new ArticleListDto
            {
                Articles = sortedArtciles,
                CategoryId = categoryId == null ? null : categoryId.Value,
                CurrentPage = currentPage,
                PageSize = pageSize,
                TotalCount = articles.Count,
                IsAscending = isAscending
            };
        }

        public async Task CreateArticleAsync(ArticleAddDto articleAddDto)
        {
            var userId = _user.GetLoggedInUserId();
            var userEmail = _user.GetLoggedInUserEmail();

            var imageUpload = await imageHelper.Upload(articleAddDto.Title, articleAddDto.Photo, ImageType.Post);
            Image image = new(imageUpload.FullName, articleAddDto.Photo.ContentType, userEmail);

            await unitOfWork.GetRepository<Image>().AddAsync(image);

            var article = new Article(articleAddDto.Title, articleAddDto.Content, articleAddDto.CategoryId, image.Id, userId, userEmail);

            await unitOfWork.GetRepository<Article>().AddAsync(article);
            await unitOfWork.SaveAsync();

        }

        public async Task<List<ArticleDto>> GetAllArticlesWithCategoryNonDeletedAsync()
        {
            var articles = await unitOfWork.GetRepository<Article>().GetAllAsync(x => !x.IsDeleted, x => x.Category, i => i.Image);

            var map = mapper.Map<List<ArticleDto>>(articles);

            return map;
        }

        public async Task<ArticleDto> GetArticleWithCategoryNonDeletedAsync(Guid articleId)
        {
            var article = await unitOfWork.GetRepository<Article>().GetAsync(x => !x.IsDeleted && x.Id == articleId, x => x.Category, i => i.Image);
            var map = mapper.Map<ArticleDto>(article);

            return map;
        }

        public async Task<string> UpdateArticleAsync(ArticleUpdateDto articleUpdateDto)
        {

            var userEmail = _user.GetLoggedInUserEmail();
            var article = await unitOfWork.GetRepository<Article>().GetAsync(x => !x.IsDeleted && x.Id == articleUpdateDto.Id, x => x.Category, i => i.Image);

            if (articleUpdateDto.Photo != null)
            {
                imageHelper.Delete(article.Image.FileName);
                var imageUpload = await imageHelper.Upload(articleUpdateDto.Title, articleUpdateDto.Photo, ImageType.Post);
                Image image = new(imageUpload.FullName, articleUpdateDto.Photo.ContentType, userEmail);
                await unitOfWork.GetRepository<Image>().AddAsync(image);

                article.ImageId = image.Id;

            }

            article.Title = articleUpdateDto.Title;
            article.Content = articleUpdateDto.Content;
            article.CategoryId = articleUpdateDto.CategoryId;
            article.ModifiedDate = DateTime.Now;
            article.ModifiedBy = _user.GetLoggedInUserEmail();

            await unitOfWork.GetRepository<Article>().UpdateAsync(article);

            await unitOfWork.SaveAsync();

            return article.Title;
        }

        public async Task<string> SafeDeleteArticleAsync(Guid articleId)
        {
            var article = await unitOfWork.GetRepository<Article>().GetByGuidAsync(articleId);

            article.IsDeleted = true;
            article.DeletedDate = DateTime.Now;
            article.DeletedBy = _user.GetLoggedInUserEmail();

            await unitOfWork.GetRepository<Article>().UpdateAsync(article);
            await unitOfWork.SaveAsync();

            return article.Title;
        }

        public async Task<List<ArticleDto>> GetAllDeletedArticlesWithCategoryNonDeletedAsync()
        {
            var articles = await unitOfWork.GetRepository<Article>().GetAllAsync(x => x.IsDeleted, x => x.Category);
            var map = mapper.Map<List<ArticleDto>>(articles);

            return map;
        }

        public async Task<string> UndoDeleteArticleAsync(Guid articleId)
        {
            var article = await unitOfWork.GetRepository<Article>().GetByGuidAsync(articleId);

            article.IsDeleted = false;
            article.DeletedDate = null;
            article.DeletedBy = null;

            await unitOfWork.GetRepository<Article>().UpdateAsync(article);
            await unitOfWork.SaveAsync();

            return article.Title;
        }
    }
}
