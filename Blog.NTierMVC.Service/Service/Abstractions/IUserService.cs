﻿using Blog.NTierMVC.Entity.DTOs.Users;
using Blog.NTierMVC.Entity.Entities;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.NTierMVC.Service.Service.Abstractions
{
    public interface IUserService
    {
        Task<List<UserDto>> GetAllUserWithRoleAsync();
        Task<List<AppRole>> GetAllRolesAsync();
        Task<IdentityResult> CreateUserAsync(UserAddDto userAddDto);
        Task<IdentityResult> UpdateUserAsync(UserUpdateDto userUpdateDto);
        Task<AppUser> GetAppUserByIdAsync(Guid Id);
        Task<string> GetUserRoleAsync(AppUser user);
        Task<(IdentityResult identityResult,string? email)> DeleteUserAsync(Guid Id);
        Task<UserProfileDto> GetUserProfileAsync();
    }
}
