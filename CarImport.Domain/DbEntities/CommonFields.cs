﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarImport.Domain.DbEntities
{
    public class CommonFields
    {

        public DateTime RecordDate = new DateTime();
        public string RecordBy { get; set; }
        public DateTime RecodLastChange { get; set; }
        public string RecordLastChangeBy { get; set; }
    }
}

