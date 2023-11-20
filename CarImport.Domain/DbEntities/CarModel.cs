using System.ComponentModel.DataAnnotations.Schema;

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
