using System.Collections.Generic;

namespace HardwareSensorSystem.Identity.Models
{
    /// <summary>
    /// Represents a user in the identity system.
    /// </summary>
    public class User
    {
        /// <summary>
        /// Gets or sets the primary key for this user.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the user name for this user.
        /// </summary>
        public string UserName { get; set; }

        /// <summary>
        /// Gets or sets a password for this user.
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// Gets or sets a salted and hashed representation of the password for this user.
        /// </summary>
        public string PasswordHash { get; set; }

        /// <summary>
        /// Gets or sets the usergroup for this user.
        /// </summary>
        public int UserGroupId { get; set; }

        /// <summary>
        /// Navigation property for the usergroup this user belongs to.
        /// </summary>
        public UserGroup UserGroup { get; set; }

        /// <summary>
        /// Navigation property for the roles this user belongs to.
        /// </summary>
        public List<Role> Roles { get; set; }

        /// <summary>
        /// A random value that change whenever a user is inserted or updated.
        /// </summary>
        public byte[] ConcurrencyToken { get; set; }
    }
}
