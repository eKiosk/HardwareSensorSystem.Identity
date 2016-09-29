using Microsoft.EntityFrameworkCore;

namespace HardwareSensorSystem.Identity.Models
{
    /// <summary>
    /// Base class for the Entity Framework database context used for identity.
    /// </summary>
    public class IdentityContext : DbContext
    {
        /// <summary>
        /// Gets or sets the <see cref="DbSet{TEntity}"/> of roles.
        /// </summary>
        public DbSet<Role> Roles { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="DbSet{TEntity}"/> of users.
        /// </summary>
        public DbSet<User> Users { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="DbSet{TEntity}"/> of usergroups.
        /// </summary>
        public DbSet<UserGroup> UserGroups { get; set; }

        /// <summary>
        /// Configures the schema needed for the identity system.
        /// </summary>
        /// <param name="modelBuilder">The modelBuilder being used to construct the model for this context.</param>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("AuthIdentity");

            modelBuilder.Entity<Role>(b =>
            {
                b.ToTable("Roles");

                b.Property(r => r.Id)
                    .ValueGeneratedOnAdd();
                b.Property(r => r.Name)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<User>(b =>
            {
                b.ToTable("Users");

                b.Property(u => u.Id)
                    .ValueGeneratedOnAdd();
                b.Property(u => u.UserName)
                    .IsRequired();
                b.Ignore(u => u.Password);
                b.Property(u => u.PasswordHash)
                    .IsRequired()
                    .HasMaxLength(68);
                b.Property(u => u.ConcurrencyToken)
                    .ValueGeneratedOnAddOrUpdate()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<UserGroup>(b =>
            {
                b.ToTable("UserGroups");

                b.Property(ug => ug.Id)
                    .ValueGeneratedOnAdd();
                b.Property(ug => ug.Name)
                    .IsRequired();
                b.Property(u => u.ConcurrencyToken)
                    .ValueGeneratedOnAddOrUpdate()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<RoleUserGroup>(b =>
            {
                b.ToTable("Roles_UserGroups");
                b.HasKey(rug => new { rug.RoleId, rug.UserGroupId });

                b.HasOne(rug => rug.Role).WithMany(r => r.RoleUserGroups).HasForeignKey(rug => rug.RoleId);
                b.HasOne(rug => rug.UserGroup).WithMany(ug => ug.RoleUserGroups).HasForeignKey(rug => rug.UserGroupId);
            });
        }
    }
}
