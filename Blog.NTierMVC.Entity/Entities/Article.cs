﻿using Blog.NTierMVC.Core.Entities;

namespace Blog.NTierMVC.Entity.Entities
{
    public class Article : EntityBase
    {
        public Article()
        {
            
        }

        public Article(string title, string content, Guid categoryId, Guid? imageId, Guid userId, string createdBy)
        {
            Title = title;
            Content = content;
            CategoryId = categoryId;
            ImageId = imageId;
            UserId = userId;
            CreatedBy = createdBy;
        }

        public string Title { get; set; }
        public string Content { get; set; }
        public int ViewCount { get; set; } = 0;
        public Guid CategoryId { get; set; }
        public Category Category{ get; set; }
        public Guid? ImageId { get; set; } 
        public Image Image{ get; set; }
        public Guid UserId { get; set; }
        public AppUser User { get; set; }
        public ICollection<ArticleVisitor> ArticleVisitors { get; set; }
    }
}
