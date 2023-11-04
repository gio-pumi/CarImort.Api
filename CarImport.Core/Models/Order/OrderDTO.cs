using CarImport.Domain.DbEntities;
using CarImport.Infrastructure.Enumerations;
using CarImport.Infrastructure.Helper;

namespace CarImport.Core.Models.Order
{
    public class OrderDTO
    {
        public int CustomerId { get; set; }

        public Status Status { get; set; }

        public int CarId { get; set; }

        public string Details { get; set; }

        public int currency { get; set; }

    }
}
