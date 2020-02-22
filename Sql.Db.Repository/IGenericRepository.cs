using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.GenericRepo
{
    public interface IGenericRepository<TEntity> where TEntity:class
    {
        Task<TEntity> GetById(object Id);
        Task Insert(TEntity Entity);
        Task Update(TEntity Entity);
        Task Delete(TEntity Entity);
        Task<IEnumerable<TEntity>> GetAll();
        Task SaveChanges();
       
    }
}
