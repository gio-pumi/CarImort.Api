using CarImport.Infrastructure.Enumerations;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;

namespace CarImport.Domain.DbEntities
{
    public class Car
    {
        public int Id { get; set; }

        public int ModelId { get; set; }

        [ForeignKey("ModelId")]
        public CarModel CarModel { get; set; }

        public DateTime DateOfManufacruring { get; set; }

        public string VINCode { get; set; }

        public decimal CarCost { get; set; }

        public Currencies Currenecies { get; set; }

        public string ImageUrl{ get; set; }

    }

}
