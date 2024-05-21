using AutoMapper;
using Blog.NTierMVC.Data.UnitOfWorks;
using Blog.NTierMVC.Entity.DTOs.Users;
using Blog.NTierMVC.Entity.Entities;
using Blog.NTierMVC.Entity.Enums;
using Blog.NTierMVC.Service.Extensions;
using Blog.NTierMVC.Service.Helpers.Images;
using Blog.NTierMVC.Service.Service.Abstractions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Blog.NTierMVC.Service.Service.Concretes
{
    public class UserService : IUserService
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper mapper;
        private readonly UserManager<AppUser> userManager;
        private readonly RoleManager<AppRole> roleManager;
        private readonly IHttpContextAccessor httpContextAccessor;
        private readonly SignInManager<AppUser> signInManager;
        private readonly IImageHelper imageHelper;
        private readonly ClaimsPrincipal _user;
        public UserService(IUnitOfWork unitOfWork, IMapper mapper, UserManager<AppUser> userManager, RoleManager<AppRole> roleManager,
            IHttpContextAccessor httpContextAccessor,SignInManager<AppUser> signInManager,IImageHelper imageHelper)
        {
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
            this.userManager = userManager;
            this.roleManager = roleManager;
            this.httpContextAccessor = httpContextAccessor;
            this.signInManager = signInManager;
            this.imageHelper = imageHelper;
            _user = httpContextAccessor.HttpContext.User;
        }

        public async Task<IdentityResult> CreateUserAsync(UserAddDto userAddDto)
        {
            var map = mapper.Map<AppUser>(userAddDto);
            map.UserName = map.Email;
            var result = await userManager.CreateAsync(map, string.IsNullOrEmpty(userAddDto.Password) ? "" : userAddDto.Password);
            if (result.Succeeded)
            {
                var findRole = await roleManager.FindByIdAsync(userAddDto.RoleId.ToString());
                await userManager.AddToRoleAsync(map, findRole.ToString());
            }
            return result;
        }

        public async Task<(IdentityResult identityResult, string? email)> DeleteUserAsync(Guid Id)
        {
            var user = await GetAppUserByIdAsync(Id);
            var result = await userManager.DeleteAsync(user);
            
            return (result,user.Email);
        }

        public async Task<List<AppRole>> GetAllRolesAsync()
        {
            var roles = await roleManager.Roles.ToListAsync();
            return roles;
        }

        public async Task<List<UserDto>> GetAllUserWithRoleAsync()
        {
            var users = await userManager.Users.ToListAsync();
            var map = mapper.Map<List<UserDto>>(users);

            foreach (var user in map)
            {
                var findUser = await userManager.FindByIdAsync(user.Id.ToString());
                var role = string.Join("", await userManager.GetRolesAsync(findUser));

                user.Role = role;
            }

            return map;
        }

        public async Task<AppUser> GetAppUserByIdAsync(Guid Id)
        {
            return await userManager.FindByIdAsync(Id.ToString());
        }

        public async Task<UserProfileDto> GetUserProfileAsync()
        {
            var userId = _user.GetLoggedInUserId();
            //var user = await GetAppUserByIdAsync(userId);
            var getUserWithImage = await unitOfWork.GetRepository<AppUser>().GetAsync(x => x.Id == userId, x => x.Image);
            var map = mapper.Map<UserProfileDto>(getUserWithImage);

            map.Image.FileName = getUserWithImage.Image.FileName;

            return map;
        }

        public async Task<string> GetUserRoleAsync(AppUser user)
        {
            return string.Join("", await userManager.GetRolesAsync(user));

        }

        public async Task<IdentityResult> UpdateUserAsync(UserUpdateDto userUpdateDto)
        {
            var user = await GetAppUserByIdAsync(userUpdateDto.Id);

            var userRole = await GetUserRoleAsync(user);

            var result = await userManager.UpdateAsync(user);
            if (result.Succeeded)
            {

                await userManager.RemoveFromRoleAsync(user, userRole);
                var findRole = await roleManager.FindByIdAsync(userUpdateDto.RoleId.ToString());
                await userManager.AddToRoleAsync(user, findRole.Name);
            }

            return result;

        }

        public async Task<bool> UpdateUserProfileAsync(UserProfileDto userProfileDto)
        {
            var userId = _user.GetLoggedInUserId();
            var user = await GetAppUserByIdAsync(userId);

            var isVerified = await userManager.CheckPasswordAsync(user, userProfileDto.CurrentPassword);

            if (isVerified && userProfileDto.NewPassword != null && userProfileDto.Photo != null)
            {
                var result = await userManager.ChangePasswordAsync(user, userProfileDto.CurrentPassword, userProfileDto.NewPassword);
                if (result.Succeeded)
                {
                    await userManager.UpdateSecurityStampAsync(user);
                    await signInManager.SignOutAsync();
                    await signInManager.PasswordSignInAsync(user, userProfileDto.NewPassword, true, false);

                    user.FirstName = userProfileDto.FirstName;
                    user.LastName = userProfileDto.LastName;
                    user.PhoneNumber = userProfileDto.PhoneNumber;

                    var imageUpload = await imageHelper.Upload($"{userProfileDto.FirstName}{userProfileDto.LastName}", userProfileDto.Photo, ImageType.User);
                    Image image = new(imageUpload.FullName, userProfileDto.Photo.ContentType, user.Email);

                    await unitOfWork.GetRepository<Image>().AddAsync(image);
                    user.ImageId = image.Id;

                    await userManager.UpdateAsync(user);

                    //toast.AddSuccessToastMessage("Şifre başarıyla değiştirilmiştir.");
                    //return View();

                    return true;
                }
                else
                    return false;
            }
            else if (isVerified && userProfileDto.Photo != null)
            {
                await userManager.UpdateSecurityStampAsync(user);

                user.FirstName = userProfileDto.FirstName;
                user.LastName = userProfileDto.LastName;
                user.PhoneNumber = userProfileDto.PhoneNumber;

                var imageUpload = await imageHelper.Upload($"{userProfileDto.FirstName}{userProfileDto.LastName}", userProfileDto.Photo, ImageType.User);
                Image image = new(imageUpload.FullName, userProfileDto.Photo.ContentType, user.Email);

                await unitOfWork.GetRepository<Image>().AddAsync(image);

                user.ImageId = image.Id;

                await userManager.UpdateAsync(user);
                await unitOfWork.SaveAsync();

                return true;

                //toast.AddSuccessToastMessage("Bilgiler başarıyla değiştirilmiştir.");
                //return View();
            }
            else
            {
                return false;
            }
        }
    }
}
