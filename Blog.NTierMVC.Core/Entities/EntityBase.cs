using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.NTierMVC.Core.Entities
{
    public abstract class EntityBase : IEntityBase
    {
        public virtual Guid Id { get; set; } = Guid.NewGuid();
        public virtual string CreatedBy { get; set; }
        public virtual string? ModifiedBy { get; set; }
        public virtual string? DeletedBy { get; set; }
        public virtual DateTime CreatedDate { get; set; } = DateTime.Now;
        public virtual DateTime ModifiedDate { get; set; }
        public virtual DateTime DeletedDate { get; set; }
        public bool IsDeleted { get; set; } = false;
    }
}
