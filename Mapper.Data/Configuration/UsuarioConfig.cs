using Mapper.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Mapper.Data.Configuration
{
    public class UsuarioConfig : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.HasKey(u => u.Id);
            builder.Property(u => u.Nome).IsRequired();
            builder.HasIndex(u => u.Nome).IsUnique();
            builder.Property(u => u.IdPerfil).IsRequired();
            builder.HasOne(u => u.Perfil).WithMany(p => p.Usuarios).HasForeignKey(u => u.IdPerfil).OnDelete(DeleteBehavior.NoAction);
        }
    }
}