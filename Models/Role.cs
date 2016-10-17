using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System.Collections.Generic;

namespace HardwareSensorSystem.Identity.Models
{
    public class Role : IdentityRole<uint>
    {
        public ICollection<UserGroupRole> UserGroups { get; }
    }
}
