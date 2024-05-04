using AutoMapper;
using Blog.NTierMVC.Entity.DTOs.Articles;
using Blog.NTierMVC.Entity.DTOs.Users;
using Blog.NTierMVC.Entity.Entities;
using Blog.NTierMVC.Web.ResultMessages;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NToastNotify;
using System.Data;

namespace Blog.NTierMVC.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class UserController : Controller
    {
        private readonly UserManager<AppUser> userManager;
        private readonly RoleManager<AppRole> roleManager;
        private readonly IMapper mapper;
        private readonly IToastNotification toast;

        public UserController(UserManager<AppUser> userManager, RoleManager<AppRole> roleManager, IMapper mapper, IToastNotification toast)
        {
            this.userManager = userManager;
            this.roleManager = roleManager;
            this.mapper = mapper;
            this.toast = toast;
        }
        public async Task<IActionResult> Index()
        {
            var users = await userManager.Users.ToListAsync();
            var map = mapper.Map<List<UserDto>>(users);

            foreach (var user in map)
            {
                var findUser = await userManager.FindByIdAsync(user.Id.ToString());
                var role = string.Join("", await userManager.GetRolesAsync(findUser));

                user.Role = role;
            }

            return View(map);
        }

        [HttpGet]
        public async Task<IActionResult> Add()
        {
            var roles = await roleManager.Roles.ToListAsync();
            return View(new UserAddDto { Roles = roles });
        }

        [HttpPost]
        public async Task<IActionResult> Add(UserAddDto userAddDto)
        {
            var map = mapper.Map<AppUser>(userAddDto);
            var roles = await roleManager.Roles.ToListAsync();

            if (ModelState.IsValid)
            {
                map.UserName = map.Email;
                var result = await userManager.CreateAsync(map, string.IsNullOrEmpty(userAddDto.Password) ? "" : userAddDto.Password);

                if (result.Succeeded)
                {
                    var findRole = await roleManager.FindByIdAsync(userAddDto.RoleId.ToString());
                    await userManager.AddToRoleAsync(map, findRole.ToString());

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
            var user = await userManager.FindByIdAsync(userId.ToString());
            var roles = await roleManager.Roles.ToListAsync();

            var map = mapper.Map<UserUpdateDto>(user);
            map.Roles = roles;

            return View(map);
        }

        [HttpPost]
        public async Task<IActionResult> Update(UserUpdateDto userUpdateDto)
        {
            var user = await userManager.FindByIdAsync(userUpdateDto.Id.ToString());
            if (user != null)
            {
                var userRole = string.Join("", await userManager.GetRolesAsync(user));
                var roles = await roleManager.Roles.ToListAsync();

                if (ModelState.IsValid)
                {
                    mapper.Map(userUpdateDto, user);
                    user.UserName = userUpdateDto.Email;
                    user.SecurityStamp = Guid.NewGuid().ToString();
                    var result = await userManager.UpdateAsync(user);
                    if (result.Succeeded)
                    {

                        await userManager.RemoveFromRoleAsync(user, userRole);

                        var findRole = await roleManager.FindByIdAsync(userUpdateDto.RoleId.ToString());
                        await userManager.AddToRoleAsync(user, findRole.Name);

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
            var user = await userManager.FindByIdAsync(userId.ToString());

            var result = await userManager.DeleteAsync(user);
            if (result.Succeeded)
            {
                toast.AddSuccessToastMessage(Messages.User.Delete(user.Email), new ToastrOptions() { Title = "Başarılı!" });
                return RedirectToAction("Index", "User", new { Area = "Admin" });
            }
            else
            {
                foreach (var errors in result.Errors)
                    ModelState.AddModelError("", errors.Description);
                
            }

            return NotFound();
        }
    }
}
