using CarImport.Core.Models;
using CarImport.Core.Models.Auth;
using CarImport.Domain.DbEntities;

namespace CarImport.Core.Interfaces
{
    public interface IAuthorizeService
    {
        Task<ServiceResponse<int>> Register(User user, string password);
		Task<ServiceResponse<string>> Login(string userName, string password);
		Task<bool> UserExists(string userName);
		Task<ServiceResponse<AuthResultDTO>> RefreshAccessToken(RefreshTokenDTO refreshTokenDTO);
    }
}
