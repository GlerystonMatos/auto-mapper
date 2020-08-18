using Mapper.Data.Context;
using Mapper.Domain.Entities;
using Mapper.Domain.Interfaces.Commun;

namespace Mapper.Data.Comun
{
    public abstract class Repository<TModel> : IRepository<TModel> where TModel : Entity
    {
        protected readonly MapperContext _context;

        public Repository(MapperContext context)
            => _context = context;
    }
}