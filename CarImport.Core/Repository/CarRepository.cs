using CarImport.Core.Interfaces;
using CarImport.Domain;
using CarImport.Domain.DbEntities;

namespace CarImport.Core.Repository
{
    public class CarRepository<T> : BaseRepository<Car>, ICarRepository<Car>
    {
        public CarRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
