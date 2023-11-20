using CarImport.Infrastructure.Enumerations;

namespace CarImport.Core.Models.Car
{
    public class CarDTO
    {

        public int ModelId { get; set; }

        public DateTime DateOfManufacruring { get; set; }

        public string VINCode { get; set; }

        public decimal CarCost { get; set; }

        public Currencies Currencies { get; set; }

        public string ImageUrl { get; set; }    
    }
}
