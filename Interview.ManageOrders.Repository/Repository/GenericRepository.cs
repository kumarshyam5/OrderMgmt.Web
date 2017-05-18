using Interview.ManageOrders.BusinessEntities.DataAccess;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace Interview.ManageOrders.Repository.Repository
{
    public class GenericRepository<T> where T:class
    {
        private DbSet<T> DbSet;
        private OrderDbContext _context;

       public GenericRepository(OrderDbContext context)
        {
            this._context = context;
            this.DbSet = this._context.Set<T>();

        }
        public IEnumerable<T> Get()
        {
            return DbSet.ToList();
        }

        /// <summary>
        /// Method to return entity by ID
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public virtual T GetbyId(int Id)
        {
            return DbSet.Find(Id);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Entity"></param>
        public void Insert(T Entity)
        {
            DbSet.Add(Entity);
        }  
        

    }
}
