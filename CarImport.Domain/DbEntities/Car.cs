using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarImport.Domain.DbEntities
{
    public class Car
    {
        public int TypeId { get; set; }

        public string ModelName { get; set; }

        public DateTime DateOfManufacruring { get; set; }

        public string VINCode { get; set; }

        public string Image { get; set; }

    }

}
