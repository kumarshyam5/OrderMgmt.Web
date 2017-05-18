using Interview.ManageOrders.BusinessServices.Interfaces;
using System.Collections.Generic;
using Interview.ManageOrders.BusinessEntities.Models;
using Interview.ManageOrders.BusinessEntities.UnitOfWork;

namespace Interview.ManageOrders.BusinessServices.Services
{
    public class OrderServices : IOrderService
    {
        private IUnitOfWork unit;
        public OrderServices(IUnitOfWork _unit)
        {
            unit = _unit;
        }
        public void AddServices(Order order)
        {
            // need to implement this
        }

        public void CancelOrder(Order order)
        {
            // need to implement this
        }

        public List<ServiceOrder> GetOrders()
        {
            return  unit.OrderRepository.Get();
           
        }

        public void SendToBilling(Order order)
        {
            // need to implement this
        }
    }

}
