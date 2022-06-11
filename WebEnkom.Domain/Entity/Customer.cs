using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebEnkom.Domain.Entity
{
    public class Customer
    {
        public int Id { get; set; }
        public string Surname { get; set; }
        public string Name { get; set; }
        public string Fathername { get; set; }
        public string Tel { get; set; }
        public string Password { get; set; }
        public int SexId { get; set; }
        public int DiscountId { get; set; }
    }
}
