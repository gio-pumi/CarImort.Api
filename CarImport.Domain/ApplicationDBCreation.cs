using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarImport.Domain
{
    internal class ApplicationDBCreation
    {
        public ApplicationDbContext DB = new ApplicationDbContext();

    }
}
