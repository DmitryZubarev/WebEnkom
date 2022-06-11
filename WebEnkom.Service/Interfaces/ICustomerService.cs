using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebEnkom.Domain.Entity;

namespace WebEnkom.Service.Interfaces
{
    public interface ICustomerService
    {
        List<Customer> GetCustomers();
    }
}
