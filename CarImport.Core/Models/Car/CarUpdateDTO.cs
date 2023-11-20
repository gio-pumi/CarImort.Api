using CarImport.Infrastructure.Enumerations;

namespace CarImport.Core.Models.Car
{
    public class CarUpdateDTO
    {
        public int Id { get; set; }

        public int ModelId { get; set; }

        public DateTime DateOfManufacruring { get; set; }

        public string VINCode { get; set; }

        public decimal CarCost { get; set; }

        public Currencies Currecy { get; set; }

        public string ImageUrl { get; set; }

    }
}
