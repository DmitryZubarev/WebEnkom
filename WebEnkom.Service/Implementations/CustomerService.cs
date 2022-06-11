using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebEnkom.DAL.Interfaces;
using WebEnkom.Domain.Entity;
using WebEnkom.Service.Interfaces;

namespace WebEnkom.Service.Implementations
{
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepository _customerRepository;

        public CustomerService(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        public List<Customer> GetCustomers()
        {
            throw new NotImplementedException();
        }
    }
}
