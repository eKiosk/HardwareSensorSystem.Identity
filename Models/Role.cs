using System.Collections.Generic;

namespace HardwareSensorSystem.Identity.Models
{
    /// <summary>
    /// Represents a role in the identity system.
    /// </summary>
    public class Role
    {
        /// <summary>
        /// Gets or sets the primary key for this role.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the name for this role.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Navigation property for the roleusergroups in this role.
        /// </summary>
        public List<RoleUserGroup> RoleUserGroups { get; set; }
    }
}
