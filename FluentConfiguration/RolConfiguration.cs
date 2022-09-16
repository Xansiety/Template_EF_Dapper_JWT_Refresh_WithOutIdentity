using Template_EF_Dapper_JWT_Refresh_WithOutIdentity.Entities.Users;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Template_EF_Dapper_JWT_Refresh_WithOutIdentity.FluentConfiguration;

public class RolConfiguration : IEntityTypeConfiguration<Rol>
    {
        public void Configure(EntityTypeBuilder<Rol> builder)
        {
            builder.ToTable("Rol");
            builder.Property(p => p.Id)
                    .IsRequired();
            builder.Property(p => p.Nombre)
                    .IsRequired()
                    .HasMaxLength(200);
            builder.Property(p => p.Activo)
                    .HasDefaultValue(true);
        }
    } 
