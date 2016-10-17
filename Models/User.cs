using OpenIddict;

namespace HardwareSensorSystem.Identity.Models
{
    /// <summary>
    /// Represents a user in the identity system.
    /// </summary>
    public class User : OpenIddictUser<uint>
    {
        public virtual uint UserGroupId { get; set; }

        public virtual UserGroup UserGroup { get; }
    }
}
