using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interview.ManageOrders.BusinessEntities.Models;
using Interview.ManageOrders.BusinessEntities.Repository;
using Interview.ManageOrders.BusinessEntities.DataAccess;

namespace Interview.ManageOrders.BusinessEntities.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private OrderDbContext _context;
        private GenericRepository<ServiceOrder> orderRepository;

        public UnitOfWork()
        {
            _context = new OrderDbContext();
        }

        public GenericRepository<ServiceOrder> OrderRepository
        {
            get
            {
                if (orderRepository == null)
                    orderRepository = new GenericRepository<ServiceOrder>(_context);

                return orderRepository;
            }

        }

        

        public void Save()
        {
            try
            {
                _context.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
