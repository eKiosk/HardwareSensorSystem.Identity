namespace HardwareSensorSystem.Identity.Models
{
    /// <summary>
    /// Represents the link between a role and a usergroup.
    /// </summary>
    public class RoleUserGroup
    {
        /// <summary>
        /// Gets or sets the primary key of the role that the roleusergroup belongs to.
        /// </summary>
        public int RoleId { get; set; }
        /// <summary>
        /// Navigation property for the role this roleusergroup belongs to.
        /// </summary>
        public Role Role { get; set; }
        /// <summary>
        /// Gets or sets the primary key of the usergroup that the roleusergroup belongs to.
        /// </summary>
        public int UserGroupId { get; set; }
        /// <summary>
        /// Navigation property for the usergroup this roleusergroup belongs to.
        /// </summary>
        public UserGroup UserGroup { get; set; }
    }
}
