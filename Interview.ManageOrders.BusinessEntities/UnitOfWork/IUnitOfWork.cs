using Interview.ManageOrders.BusinessEntities.Models;
using Interview.ManageOrders.BusinessEntities.Repository;

namespace Interview.ManageOrders.BusinessEntities.UnitOfWork
{
    public interface IUnitOfWork
    {

        void Save();

        GenericRepository<ServiceOrder> OrderRepository { get; }
    }
}
