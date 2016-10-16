using Microsoft.EntityFrameworkCore;
using OpenIddict;

namespace HardwareSensorSystem.Identity.Models
{
    /// <summary>
    /// Base class for the Entity Framework database context used for identity.
    /// </summary>
    public class IdentityContext : OpenIddictDbContext<User, Role, uint>
    {
        /// <summary>
        /// Configures the schema needed for the identity system.
        /// </summary>
        /// <param name="modelBuilder">The modelBuilder being used to construct the model for this context.</param>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
