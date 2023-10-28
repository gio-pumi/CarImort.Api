using CarImport.Infrastructure.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
