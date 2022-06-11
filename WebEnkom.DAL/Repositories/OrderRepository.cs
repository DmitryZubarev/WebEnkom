using System.Collections.Generic;
using System.Linq;
using WebEnkom.DAL.Interfaces;
using WebEnkom.Domain.Entity;

namespace WebEnkom.DAL.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        private readonly ApplicationDbContext _context;



        public OrderRepository(ApplicationDbContext context)
        {
            _context = context;
        }



        public bool Create(Order entity)
        {
            _context.Order.Add(entity);
            _context.SaveChanges();

            return true;
        }

        public bool Delete(Order entity)
        {
            _context.Order.Remove(entity);
            _context.SaveChanges();

            return true;
        }

        public Order Get(int id)
        {
            return _context.Order.FirstOrDefault(x => x.Id == id);
        }

        public List<Order> Select()
        {
            return _context.Order.ToList();
        }
    }
}
