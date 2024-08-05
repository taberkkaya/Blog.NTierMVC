using Blog.NTierMVC.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.NTierMVC.Entity.Entities
{
    public class SocialMedia : EntityBase,IEntityBase
    {
        public string Name { get; set; }
        public string Url { get; set; }
        public string Icon { get; set; }
        AppUser User { get; set; }
    }
}
