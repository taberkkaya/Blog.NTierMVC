﻿using Blog.NTierMVC.Entity.DTOs.Articles;

namespace Blog.NTierMVC.Service.Service.Abstractions
{
    public interface IArticleService
    {
        Task<List<ArticleDto>> GetAllArticlesAsync();

    }
}
