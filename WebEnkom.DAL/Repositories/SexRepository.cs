using System.Collections.Generic;
using System.Linq;
using WebEnkom.DAL.Interfaces;
using WebEnkom.Domain.Entity;

namespace WebEnkom.DAL.Repositories
{
    public class SexRepository : ISexRepository
    {
        private readonly ApplicationDbContext _context;



        public SexRepository(ApplicationDbContext context)
        {
            _context = context;
        }



        public bool Create(Sex entity)
        {
            _context.Sex.Add(entity);
            _context.SaveChanges();

            return true;
        }

        public bool Delete(Sex entity)
        {
            _context.Sex.Remove(entity);
            _context.SaveChanges();

            return true;
        }

        public Sex Get(int id)
        {
            return _context.Sex.FirstOrDefault(x => x.Id == id);
        }

        public List<Sex> Select()
        {
            return _context.Sex.ToList();
        }

        public Sex GetByName(string name)
        {
            return _context.Sex.FirstOrDefault(x => x.Name == name);
        }
    }
}
