using Interview.ManageOrders.BusinessEntities.Models;
using System;

namespace Interview.ManageOrders.DTO.Mappers
{
    public class ServiceOrderEntity
    {
       
        public int ServiceOrdersID { get; set; }

        public int OrdersID { get; set; }

        public int ServiceTypesID { get; set; }

        public DateTime? OrderedDate { get; set; }


        public string LastUpdatedBy { get; set; }

        public bool? DeletedStatus { get; set; }

        public  Order Order { get; set; }

        public  ServiceType ServiceType { get; set; }

    }
}
