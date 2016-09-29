using System.Collections.Generic;

namespace HardwareSensorSystem.Identity.Models
{
    /// <summary>
    /// Represents a usergroup in the identity system.
    /// </summary>
    public class UserGroup
    {
        /// <summary>
        /// Gets or sets the primary key for this usergroup.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the name for this usergroup.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Navigation property for the roleusergroups in this usergroup.
        /// </summary>
        public List<RoleUserGroup> RoleUserGroups { get; set; }

        /// <summary>
        /// A random value that change whenever a usergroup is inserted or updated.
        /// </summary>
        public byte[] ConcurrencyToken { get; set; }
    }
}
