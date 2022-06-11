using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebEnkom.Domain.Entity
{
    public class Order
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public int DeliveryId { get; set; }
        public string Street { get; set; }
        public string House { get; set; }
        public int? Flat { get; set; }
    }
}
