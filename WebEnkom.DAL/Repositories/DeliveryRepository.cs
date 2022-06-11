using System.Collections.Generic;
using System.Linq;
using WebEnkom.DAL.Interfaces;
using WebEnkom.Domain.Entity;

namespace WebEnkom.DAL.Repositories
{
    public class DeliveryRepository : IDeliveryRepository
    {
        private readonly ApplicationDbContext _context;



        public DeliveryRepository(ApplicationDbContext context)
        {
            _context = context;
        }



        public bool Create(Delivery entity)
        {
            _context.Delivery.Add(entity);
            _context.SaveChanges();

            return true;
        }

        public bool Delete(Delivery entity)
        {
            _context.Delivery.Remove(entity);
            _context.SaveChanges();

            return true;
        }

        public Delivery Get(int id)
        {
            return _context.Delivery.FirstOrDefault(x => x.Id == id);
        }

        public Delivery GetByArea(string name)
        {
            return _context.Delivery.FirstOrDefault(x => x.Area == name);
        }

        public List<Delivery> Select()
        {
            return _context.Delivery.ToList();
        }
    }
}
