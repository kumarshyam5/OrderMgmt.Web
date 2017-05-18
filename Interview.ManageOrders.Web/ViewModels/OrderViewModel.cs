using Interview.ManageOrders.DTO.Mappers;
using System.Collections.Generic;

namespace Interview.ManageOrders.Web.ViewModels
{
    public class OrderViewModel
    {
        public int OrdersID { get; set; }
     
        public string AccountNumber { get; set; }
       
        public string CustomerName { get; set; }

       public int ServiceTypes { get; set; }
    }
}