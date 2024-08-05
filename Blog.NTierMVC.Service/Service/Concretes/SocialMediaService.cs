using AutoMapper;
using Blog.NTierMVC.Data.UnitOfWorks;
using Blog.NTierMVC.Entity.DTOs.Categories;
using Blog.NTierMVC.Entity.Entities;
using Blog.NTierMVC.Service.Service.Abstractions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.NTierMVC.Service.Service.Concretes
{
    public class SocialMediaService : ISocialMediaService
    {
        private readonly IUnitOfWork unitOfWork;

        public SocialMediaService(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }
        public Task<List<SocialMedia>> GetAllSocialMediasNonDeleted()
        {
            var socialMedias = unitOfWork.GetRepository<SocialMedia>().GetAllAsync(x => !x.IsDeleted);
            return socialMedias;
        }

        public async Task<string> UpdateSocialMediaAsync(SocialMedia socialMedia)
        {
            //var userEmail = _user.GetLoggedInUserEmail();
            var social = await unitOfWork.GetRepository<SocialMedia>().GetAsync(x => !x.IsDeleted && x.Id == socialMedia.Id);

            social.Name = socialMedia.Name;
            //category.ModifiedBy = userEmail;
            social.ModifiedDate = DateTime.Now;

            await unitOfWork.GetRepository<SocialMedia>().UpdateAsync(social);
            await unitOfWork.SaveAsync();

            return social.Name;
        }

        public async Task<string> SafeDeleteSocialMediaAsync(Guid socialMediaId)
        {
            var social = await unitOfWork.GetRepository<SocialMedia>().GetByGuidAsync(socialMediaId);

            social.IsDeleted = true;
            social.DeletedDate = DateTime.Now;
            //social.DeletedBy = _user.GetLoggedInUserEmail();

            await unitOfWork.GetRepository<SocialMedia>().UpdateAsync(social);
            await unitOfWork.SaveAsync();

            return social.Name;
        }

        public async Task Add(SocialMedia socialMedia)
        {
            await unitOfWork.GetRepository<SocialMedia>().AddAsync(socialMedia);
            await unitOfWork.SaveAsync();
        }
    }
}
