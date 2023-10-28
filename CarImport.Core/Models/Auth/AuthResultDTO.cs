using CarImport.Core.Models.Token;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarImport.Core.Models.Auth
{
    public class AuthResultDTO : TokenDTO
    {
        public bool Confirmed { get; set; }
    }
}
