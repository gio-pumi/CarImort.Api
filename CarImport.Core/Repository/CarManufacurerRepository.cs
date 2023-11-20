using CarImport.Core.Interfaces;
using CarImport.Domain;
using CarImport.Domain.DbEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarImport.Core.Repository
{
    public class CarManufacurerRepository<T> : BaseRepository<CarManufacturer>, ICarManufaturerRepository<CarManufacturer>
    {
        public CarManufacurerRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
