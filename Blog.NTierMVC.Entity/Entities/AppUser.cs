﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.NTierMVC.Entity.Entities
{
    public class AppUser : IdentityUser<Guid>
    {
        public string FistName { get; set; }
        public string LastName { get; set; }
    }
}
