using CarImport.Core.Models;
using CarImport.Core.Models.Auth;
using CarImport.Domain.DbEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
