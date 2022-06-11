using System.Collections.Generic;
using System.Linq;
using WebEnkom.DAL.Interfaces;
using WebEnkom.Domain.Entity;

namespace WebEnkom.DAL.Repositories
{
    public class DiscountRepository : IDiscountRepository
    {
        private readonly ApplicationDbContext _context;



        public DiscountRepository(ApplicationDbContext context)
        {
            _context = context;
        }



        public bool Create(Discount entity)
        {
            _context.Discount.Add(entity);
            _context.SaveChanges();

            return true;
        }

        public bool Delete(Discount entity)
        {
            _context.Discount.Remove(entity);
            _context.SaveChanges();

            return true;
        }

        public Discount Get(int id)
        {
            return _context.Discount.FirstOrDefault(x => x.Id == id);
        }

        public List<Discount> Select()
        {
            return _context.Discount.ToList();
        }
    }
}
