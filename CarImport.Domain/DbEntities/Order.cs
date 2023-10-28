using CarImport.Infrastructure.Enumerations;
using CarImport.Infrastructure.Helper;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace CarImport.Domain.DbEntities
{
    public class Order : CommonFields
    {
        public int Id { get; set; }

        public int CarId { get; set; }
        [ForeignKey("CarId")]
        public Car Car { get; set; }

        public int CustomerId { get; set; }
        [ForeignKey("CustomerId")]
        public Customer Customer { get; set; }

        public Status Status { get; set; }

        public string Details { get; set; }

    }
}
