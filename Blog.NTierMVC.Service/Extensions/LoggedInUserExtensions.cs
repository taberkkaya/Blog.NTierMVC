using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Blog.NTierMVC.Service.Extensions
{
    public static class LoggedInUserExtensions
    {
        public static Guid GetLoggedInUserId(this ClaimsPrincipal principal)
        {
            return Guid.Parse(principal.FindFirstValue(ClaimTypes.NameIdentifier));
        }

        public static string GetLoggedInUserEmail(this ClaimsPrincipal principal) {
            return principal.FindFirstValue(ClaimTypes.Email);
        }
    }
}
