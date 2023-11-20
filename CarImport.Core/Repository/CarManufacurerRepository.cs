using CarImport.Core.Interfaces;
using CarImport.Domain;
using CarImport.Domain.DbEntities;

namespace CarImport.Core.Repository
{
    public class CarManufacurerRepository<T> : BaseRepository<CarManufacturer>, ICarManufaturerRepository<CarManufacturer>
    {
        public CarManufacurerRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
