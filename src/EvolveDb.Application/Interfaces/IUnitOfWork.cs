using System.Collections.Generic;
using System.Threading.Tasks;
using EvolveDb.Domain;

namespace EvolveDb.Application.Interfaces
{
    public interface IUnitOfWork
    {
        IGenericCrudRepository<TEntity, TKey> Repository<TEntity, TKey>()
            where TEntity : BaseEntity<TKey>;
    }
}
