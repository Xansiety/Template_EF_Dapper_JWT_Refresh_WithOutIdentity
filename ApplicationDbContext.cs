using Template_EF_Dapper_JWT_Refresh_WithOutIdentity.Entities.Users;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace Template_EF_Dapper_JWT_Refresh_WithOutIdentity
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("TI"); //SCHEMA CREATE
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly()); //aplicar las configuraciones desde Folder FluentConfiguration
        }

        //ENTITIES ON DB
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Rol> Roles { get; set; }

    }
}
