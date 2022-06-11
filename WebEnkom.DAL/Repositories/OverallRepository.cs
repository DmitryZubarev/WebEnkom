using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebEnkom.DAL.Interfaces;
using WebEnkom.Domain.Entity;

namespace WebEnkom.DAL.Repositories
{
    public class OverallRepository : IOverallRepository
    {
        private readonly ApplicationDbContext _context;



        public OverallRepository(ApplicationDbContext context)
        {
            _context = context;
        }



        public bool Create(Overall entity)
        {
            _context.Overall.Add(entity);
            _context.SaveChanges();

            return true;
        }

        public bool Delete(Overall entity)
        {
            _context.Overall.Remove(entity);
            _context.SaveChanges();

            return true;
        }

        public Overall Get(int id)
        {
            return _context.Overall.FirstOrDefault(x => x.Id == id);
        }

        public List<Overall> Select()
        {
            return _context.Overall.ToList();
        }
    }
}
