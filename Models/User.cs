using OpenIddict;

namespace HardwareSensorSystem.Identity.Models
{
    /// <summary>
    /// Represents a user in the identity system.
    /// </summary>
    public class User : OpenIddictUser<int>
    {
        /// <summary>
        /// Gets or sets the primary key of the usergroup that the user belongs to.
        /// </summary>
        public int UserGroupId { get; set; }

        /// <summary>
        /// Navigation property for the usergroup this user belongs to.
        /// </summary>
        public UserGroup UserGroup { get; set; }
    }
}
