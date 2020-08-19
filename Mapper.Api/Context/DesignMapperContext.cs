using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Mapper.Api.Context
{
    public class DesignMapperContext : IDesignTimeDbContextFactory<MapperContext>
    {
        public MapperContext CreateDbContext(string[] args)
        {
            var local = "Data Source=GLERYSTON-PC\\SQLEXPRESS;Initial Catalog=Mapper;Persist Security Info=True;User ID=sa;Password=1234";
            DbContextOptionsBuilder<MapperContext> builder = new DbContextOptionsBuilder<MapperContext>();
            builder.UseSqlServer(local);
            return new MapperContext(builder.Options);
        }
    }
}