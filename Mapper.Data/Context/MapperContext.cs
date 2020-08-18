using Mapper.Data.Configuration;
using Mapper.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Mapper.Data.Context
{
    public class MapperContext : DbContext
    {
        private readonly IConfiguration _configuration;

        public MapperContext(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public MapperContext(DbContextOptions<MapperContext> options) : base(options)
        {
        }

        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<Perfil> Perfil { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new UsuarioConfig());
            modelBuilder.ApplyConfiguration(new PerfilConfig());

            Perfil perfil = new Perfil("Administrador");
            modelBuilder.Entity<Perfil>().HasData(
                perfil);

            Usuario usuario01 = new Usuario("Snoopy");
            usuario01.IdPerfil = perfil.Id;
            Usuario usuario02 = new Usuario("Lola");
            usuario02.IdPerfil = perfil.Id;
            Usuario usuario03 = new Usuario("Tobias");
            usuario03.IdPerfil = perfil.Id;

            modelBuilder.Entity<Usuario>().HasData(
                usuario01,
                usuario02,
                usuario03);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (_configuration != null)
            {
                optionsBuilder.UseSqlServer(_configuration.GetConnectionString("DefaultConnection"));
            }
        }
    }
}