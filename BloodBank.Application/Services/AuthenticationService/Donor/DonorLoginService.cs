using BloodBank.Application.Common.Response;
using BloodBank.Application.Interfaces.IServices.IAuthenticationService.Donor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodBank.Application.Services.AuthenticationService.Donor
{
    public class DonorLoginService : IDonorLoignService
    {
        public Task<ApiResponse<object>> DonorLogin(string username, string password)
        {
            try
            {

            }
            catch(Exception ex)
            {

            }
        }
    }
}
