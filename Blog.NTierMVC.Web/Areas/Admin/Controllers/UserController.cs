using AutoMapper;
using Blog.NTierMVC.Entity.DTOs.Articles;
using Blog.NTierMVC.Entity.DTOs.Users;
using Blog.NTierMVC.Entity.Entities;
using Blog.NTierMVC.Web.ResultMessages;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using NToastNotify;
using System.Data;
using Microsoft.AspNetCore.Identity;
using Blog.NTierMVC.Entity.Enums;
using Blog.NTierMVC.Service.Helpers.Images;
using Blog.NTierMVC.Data.UnitOfWorks;
using Blog.NTierMVC.Service.Service.Abstractions;
using FluentValidation;
using Blog.NTierMVC.Service.Extensions;
using static Blog.NTierMVC.Web.ResultMessages.Messages;

namespace Blog.NTierMVC.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class UserController : Controller
    {
        private readonly IUserService userService;
        private readonly UserManager<AppUser> userManager;
        private readonly RoleManager<AppRole> roleManager;
        private readonly IValidator<AppUser> validator;
        private readonly SignInManager<AppUser> signInManager;
        private readonly IMapper mapper;
        private readonly IToastNotification toast;
        private readonly IImageHelper imageHelper;
        private readonly IUnitOfWork unitOfWork;

        public UserController(IUserService userService, UserManager<AppUser> userManager, RoleManager<AppRole> roleManager, SignInManager<AppUser> signInManager, IMapper mapper, IToastNotification toast, IImageHelper imageHelper, IUnitOfWork unitOfWork)
        {
            this.userService = userService;
            this.userManager = userManager;
            this.roleManager = roleManager;
            this.validator = validator;
            this.signInManager = signInManager;
            this.mapper = mapper;
            this.toast = toast;
            this.imageHelper = imageHelper;
            this.unitOfWork = unitOfWork;
        }
        public async Task<IActionResult> Index()
        {
            var result = await userService.GetAllUserWithRoleAsync();

            return View(result);
        }

        [HttpGet]
        public async Task<IActionResult> Add()
        {
            var roles = await userService.GetAllRolesAsync();
            return View(new UserAddDto { Roles = roles });
        }

        [HttpPost]
        public async Task<IActionResult> Add(UserAddDto userAddDto)
        {
            var map = mapper.Map<AppUser>(userAddDto);
            var roles = await userService.GetAllRolesAsync();

            if (ModelState.IsValid)
            {

                var result = await userService.CreateUserAsync(userAddDto);
                if (result.Succeeded)
                {
                    toast.AddSuccessToastMessage(Messages.User.Add(userAddDto.Email), new ToastrOptions() { Title = "Başarılı!" });
                    return RedirectToAction("Index", "User", new { Area = "Admin" });
                }
                else
                {
                    foreach (var errors in result.Errors)
                        ModelState.AddModelError("", errors.Description);
                    return View(new UserAddDto { Roles = roles });
                }
            }

            return View(new UserAddDto { Roles = roles });

        }

        [HttpGet]
        public async Task<IActionResult> Update(Guid userId)
        {
            var user = await userService.GetAppUserByIdAsync(userId);
            var roles = await roleManager.Roles.ToListAsync();

            var map = mapper.Map<UserUpdateDto>(user);
            map.Roles = roles;

            return View(map);
        }

        [HttpPost]
        public async Task<IActionResult> Update(UserUpdateDto userUpdateDto)
        {
            var user = await userService.GetAppUserByIdAsync(userUpdateDto.Id);
            if (user != null)
            {
                var userRole = await userService.GetUserRoleAsync(user);
                var roles = await userService.GetAllRolesAsync();

                if (ModelState.IsValid)
                {
                    mapper.Map(userUpdateDto, user);
                    user.UserName = userUpdateDto.Email;
                    user.SecurityStamp = Guid.NewGuid().ToString();
                    var result = await userService.UpdateUserAsync(userUpdateDto);
                    if (result.Succeeded)
                    {
                        toast.AddSuccessToastMessage(Messages.User.Update(userUpdateDto.Email), new ToastrOptions() { Title = "Başarılı!" });
                        return RedirectToAction("Index", "User", new { Area = "Admin" });
                    }
                    else
                    {
                        foreach (var errors in result.Errors)
                            ModelState.AddModelError("", errors.Description);
                        return View(new UserUpdateDto { Roles = roles });
                    }
                }

            }
            return NotFound();
        }

        public async Task<IActionResult> Delete(Guid userId)
        {
            //var user = await userService.GetAppUserByIdAsync(userId);

            var result = await userService.DeleteUserAsync(userId);

            if (result.identityResult.Succeeded)
            {
                toast.AddSuccessToastMessage(Messages.User.Delete(result.email), new ToastrOptions() { Title = "Başarılı!" });
                return RedirectToAction("Index", "User", new { Area = "Admin" });
            }
            else
            {
                foreach (var errors in result.identityResult.Errors)
                    ModelState.AddModelError("", errors.Description);

            }

            return NotFound();
        }

        [HttpGet]
        public async Task<IActionResult> Profile()
        {
            var user = await userService.GetUserProfileAsync();

            return View(user);
        }

        [HttpPost]
        public async Task<IActionResult> Profile(UserProfileDto userProfileDto)
        {
            var user = await userManager.GetUserAsync(HttpContext.User);

            if (ModelState.IsValid)
            {
               

               
                
            }

            return View();
        }
    }
}
