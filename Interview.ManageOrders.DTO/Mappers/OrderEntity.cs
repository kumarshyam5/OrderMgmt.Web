using Interview.ManageOrders.BusinessEntities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview.ManageOrders.DTO.Mappers
{
   public  class OrderEntity
    {
        
        public int OrdersID { get; set; }

       
        public string AccountNumber { get; set; }

      
        public string CustomerName { get; set; }

      
        public  List<ServiceOrderEntity> ServiceOrders { get; set; }
    }
}
