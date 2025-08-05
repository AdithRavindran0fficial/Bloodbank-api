using BloodBank.Application.Common.Response;
using BloodBank.Application.DTOs.AuthenticationDTO.DonorDTO;
using BloodBank.Application.DTOs.AuthenticationDTO.UserDTO;
using BloodBank.Application.Interfaces.IRepository.IAuthenticationRepo.IDonorRepo;
using BloodBank.Application.Interfaces.IServices.IAuthenticationService.Donor;
using BloodBank.Application.Interfaces.IServices.IHelperService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodBank.Application.Services.AuthenticationService.Donor
{
    public class UserLoginService : IUserLoignService
    {
        private readonly IUserLoginRepo donorLogin;
        private readonly ITokenProvider tokenProvider;
        public UserLoginService(IUserLoginRepo donorLoginRepo)
        {
            donorLogin = donorLoginRepo;
        }
        public async Task<ApiResponse<object>> DonorLogin(UserLoginDto donor)
        {
            try
            {
                

                var result =await  donorLogin.Login(donor);
                if (result == null)
                {
                    return new ApiResponse<object>("user not  found", 401, true);
                }
                else
                {
                    var loginres = new LoginResponse
                    {
                        Token = tokenProvider.GetToken(result),
                        UserName = result.Name
                    };
                    return new ApiResponse<object>("user  found", 200, true,loginres);

                }
            }
            catch(Exception ex)
            {
                return new ApiResponse<object>(ex.Message, 500, false);

            }
        }
    }
}
