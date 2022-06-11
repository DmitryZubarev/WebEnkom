using System.Collections.Generic;
using System.Linq;
using WebEnkom.DAL.Interfaces;
using WebEnkom.Domain.Entity;

namespace WebEnkom.DAL.Repositories
{
    public class ProductTypeRepository : IProductTypeRepository
    {
        private readonly ApplicationDbContext _context;



        public ProductTypeRepository(ApplicationDbContext context)
        {
            _context = context;
        }



        public bool Create(ProductType entity)
        {
            _context.ProductType.Add(entity);
            _context.SaveChanges();

            return true;
        }

        public bool Delete(ProductType entity)
        {
            _context.ProductType.Remove(entity);
            _context.SaveChanges();

            return true;
        }

        public ProductType Get(int id)
        {
            return _context.ProductType.FirstOrDefault(x => x.Id == id);
        }

        public List<ProductType> Select()
        {
            return _context.ProductType.ToList();
        }
    }
}
