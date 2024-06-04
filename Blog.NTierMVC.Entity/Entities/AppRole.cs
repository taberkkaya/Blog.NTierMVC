using Blog.NTierMVC.Core.Entities;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.NTierMVC.Entity.Entities
{
    public class AppRole : IdentityRole<Guid>,IEntityBase 
    {
    }
}
