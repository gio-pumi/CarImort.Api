using CarImport.Domain.DbEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarImport.Core.Models.CarManufacturer
{
    public class CarManufacturerUpdateDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
