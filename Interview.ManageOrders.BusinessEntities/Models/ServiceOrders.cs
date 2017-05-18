using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview.ManageOrders.BusinessEntities.Models
{
    public class ServiceOrder
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ServiceOrdersID { get; set; }

        public int OrdersID { get; set; }

        public int ServiceTypesID { get; set; }

        public DateTime? OrderedDate { get; set; }

        [StringLength(20)]
        public string LastUpdatedBy { get; set; }

        public bool? DeletedStatus { get; set; }

        public virtual Order Order { get; set; }

        public virtual ServiceType ServiceType { get; set; }
    }
}

