﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarImport.Domain.DbEntities
{
    public class CommonFields
    {
        public DateTime CreateDate { get; set; } = DateTime.Now;

        public string ModifierUser { get; set; }

        public DateTime LastModifyDate { get; set; } 

        public string LastModifierUser { get; set; }
    }
}
