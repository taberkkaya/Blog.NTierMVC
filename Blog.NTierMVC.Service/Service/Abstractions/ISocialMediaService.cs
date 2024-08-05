using Blog.NTierMVC.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.NTierMVC.Service.Service.Abstractions
{
    public interface ISocialMediaService
    {
        public Task<List<SocialMedia>> GetAllSocialMediasNonDeleted();
        public Task<string> UpdateSocialMediaAsync(SocialMedia socialMediaId);
        public Task<string> SafeDeleteSocialMediaAsync(Guid socialMediaId);
        public Task Add(SocialMedia socialMedia);
    }
}
