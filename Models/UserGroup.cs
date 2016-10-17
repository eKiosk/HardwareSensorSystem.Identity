using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HardwareSensorSystem.Identity.Models
{
    public class UserGroup
    {
        public virtual uint Id { get; set; }

        public virtual string Name { get; set; }

        public virtual ICollection<User> Users { get; }
    }
}
