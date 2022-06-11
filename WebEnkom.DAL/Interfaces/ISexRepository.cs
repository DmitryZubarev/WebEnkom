using WebEnkom.Domain.Entity;

namespace WebEnkom.DAL.Interfaces
{
    public interface ISexRepository : IBaseRepository<Sex>
    {
        Sex GetByName(string name);
    }
}
