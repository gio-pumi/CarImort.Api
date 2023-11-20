using CarImport.Infrastructure.Helper;

namespace CarImport.Core.Models.Order
{
    public class OrderUpdateDTO
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }

        public Status Status { get; set; }

        public int CarId { get; set; }
        public string Details { get; set; }

    }
}
