using System.ComponentModel.DataAnnotations;

namespace CarImport.Core.Models.Auth
{
    public class RefreshTokenDTO
    {
        [Required]
        public string RefreshToken { get; set; }
    }
}
