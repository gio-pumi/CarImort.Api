using CarImport.Infrastructure.Helper;

namespace CarImport.Domain.DbEntities
{
    public class Order:CommonFields
    {
        public int ID { get; set; }

        public CarManufacturer Manufacturer { get; set; }

        public string OrderName { get; set; }

        public Status Status { get; set; }

        public decimal CarCost { get; set; }

        public string Currecy { get; set; }

        public string Details { get; set; }

    }
}
