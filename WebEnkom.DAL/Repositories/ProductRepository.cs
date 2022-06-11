using System.Collections.Generic;
using System.Linq;
using WebEnkom.DAL.Interfaces;
using WebEnkom.Domain.Entity;

namespace WebEnkom.DAL.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly ApplicationDbContext _context;



        public ProductRepository(ApplicationDbContext context)
        {
            _context = context;
        }



        public bool Create(Product entity)
        {
            _context.Product.Add(entity);
            _context.SaveChanges();

            return true;
        }

        public bool Delete(Product entity)
        {
            _context.Product.Remove(entity);
            _context.SaveChanges();

            return true;
        }

        public Product Get(int id)
        {
            return _context.Product.FirstOrDefault(x => x.Id == id);
        }

        public List<Product> Select()
        {
            return _context.Product.ToList();
        }
    }
}
