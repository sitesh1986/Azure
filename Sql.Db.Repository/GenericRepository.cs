using Microsoft.EntityFrameworkCore;
using Models;
using System;
using System.Collections.Generic;

using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;


namespace Repository.GenericRepo
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class
    {
        private readonly Context _context;
        private DbSet<TEntity> _dbSet;

        protected DbSet<TEntity> DBSet
        {
            get
            {
                if (_dbSet == null)
                {
                    _dbSet = this._context.Set<TEntity>();
                }

                return _dbSet;
            }
        }
        public GenericRepository(Context context)
        {
            this._context = context;
            this._dbSet = this._context.Set<TEntity>();
        }

       

        

        public async Task Delete(TEntity Entity)
        {
            if (this._context.Entry(Entity).State == EntityState.Detached)
                this.Attach(Entity);

            DBSet.Remove(Entity);
        }

       

        public async Task<TEntity> GetById(object Id)
        {
           return await this._dbSet.FindAsync(Id);
        }

        public async Task Insert(TEntity Entity)
        {
            await this.DBSet.AddAsync(Entity);
        }

        public async Task Update(TEntity Entity)
        {
             _dbSet.Attach(Entity);
            this._context.Entry(Entity).State = EntityState.Modified; 
        }
        public virtual void Attach(TEntity entity)
        {
            if (this._context.Entry(entity).State == EntityState.Detached)
                this.DBSet.Attach(entity);
        }
       
        public async Task SaveChanges()
        {
            await this._context.SaveChangesAsync();
        }

        public async Task<IEnumerable<TEntity>> GetAll()
        {
            return await this._dbSet.ToListAsync();
        }
    }
}
