using CarImport.Core.Models.Token;

namespace CarImport.Core.Models.Auth
{
    public class AuthResultDTO : TokenDTO
    {
        public bool Confirmed { get; set; }
    }
}
