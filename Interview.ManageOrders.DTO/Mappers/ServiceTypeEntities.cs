using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview.ManageOrders.DTO.Mappers
{
    public class ServiceTypeEntities
    {
        public int ServiceTypesID { get; set; }

        public string ServiceName { get; set; }
        
        public  List<ServiceOrderEntity> ServiceOrders { get; set; }
    }
}
