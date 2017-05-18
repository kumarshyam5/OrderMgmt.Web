using Interview.ManageOrders.BusinessEntities.Models;
using Interview.ManageOrders.DTO.Mappers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview.ManageOrders.BusinessServices.Interfaces
{
    public interface IOrderService
    {
        void AddServices(Order order);

        void CancelOrder(Order order);

        void SendToBilling(Order order);


        /// <summary>
        /// Method to return list of order details
        /// </summary>
        /// <returns></returns>
        List<ServiceOrder> GetOrders();


    }
}
