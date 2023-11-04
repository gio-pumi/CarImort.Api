using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarImport.Domain.DbEntities
{
    public class CarManufacturer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<CarModel> CarModels { get; set; }
    }
}
 