using System.Collections.Generic;
using System.Threading.Tasks;

namespace HR.LeaveManagment.Application.Persistence.Contracts
{
    public interface IGenericRepository<TEntity> where TEntity : class
    {
        Task<TEntity> Get(int id);
        Task<IReadOnlyList<TEntity>> GetAll();
        Task<TEntity> Add(TEntity entity);
        Task<TEntity> Update(TEntity entity);
        Task<TEntity> Delete(TEntity entity);
    }
}
