using System.Collections.Generic;
using System.Threading.Tasks;

namespace University.BL.Repositories
{
    public interface IGenericRepository<TEntity> where TEntity : class
    {
        //Task es para tareas asincronas
        //Entity es cualquiera de los modelos, es generico.
        Task<IEnumerable<TEntity>> GetAll();
        Task<TEntity> GetById(int id);
        Task<TEntity> Insert(TEntity entity);
        Task<TEntity> Update(TEntity entity);
        Task Delete(int id);
    }
}
