using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarImport.Core.Models.Customer
{
    public class CustomerUpdateDTO
    {
        public int Id { get; set; }
        public int PersonalNumber { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }

    }
}
