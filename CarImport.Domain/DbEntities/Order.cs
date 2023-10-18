using CarImport.Infrastructure.Helper;
using System.Collections.Generic;

namespace CarImport.Domain.DbEntities
{
    public class Order:CommonFields
    {
        public int ID { get; set; }

        public Customer Customer { get; set; }

        public Status Status { get; set; }

        public decimal CarCost { get; set; }

        public string Currecy { get; set; }

        public string Details { get; set; }

    }
}
