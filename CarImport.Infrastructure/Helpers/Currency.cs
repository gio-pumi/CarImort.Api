using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarImport.Infrastructure.Helpers
{
    public class Currency
    {

        public Data data { get; set; }

        public class Data
        {
            public float EUR { get; set; }
            public float ILS { get; set; }
            public int USD { get; set; }
            
        }
    }
}
