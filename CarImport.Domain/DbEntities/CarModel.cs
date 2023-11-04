using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarImport.Domain.DbEntities
{
    public class CarModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CarManufacturerId { get; set; }

        [ForeignKey("CarManufacturerId")]
        public CarManufacturer CarManufacturer { get; set; }
        public List<Car> Cars { get; set; }
    }
}
