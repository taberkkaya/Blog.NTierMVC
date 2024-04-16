using Blog.NTierMVC.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.NTierMVC.Service.Service.Abstractions
{
    public interface IArticleService
    {
        Task<List<Article>> GetAllArticlesAsync();

    }
}
