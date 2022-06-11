using System.Collections.Generic;
using System.Linq;
using WebEnkom.DAL.Interfaces;
using WebEnkom.Domain.Entity;

namespace WebEnkom.DAL.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly ApplicationDbContext _context;



        public CustomerRepository(ApplicationDbContext context)
        {
            _context = context;
        }



        public bool Create(Customer entity)
        {
            _context.Customer.Add(entity);
            _context.SaveChanges();

            return true;
        }

        public bool Delete(Customer entity)
        {
            _context.Customer.Remove(entity);
            _context.SaveChanges();

            return true;
        }

        public Customer Get(int id)
        {
            return _context.Customer.FirstOrDefault(x => x.Id == id);
        }

        public Customer GetByTel(string tel)
        {
            return _context.Customer.FirstOrDefault(x => x.Tel == tel);
        }

        public List<Customer> Select()
        {
            return _context.Customer.ToList();
        }
    }
}
