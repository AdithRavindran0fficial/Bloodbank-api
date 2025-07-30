using BloodBank.Application.Common.Response;
using BloodBank.Application.DTOs.AuthenticationDTO.DonorDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodBank.Application.Interfaces.IServices.IAuthenticationService.Donor
{
    public interface IDonorLoignService
    {
        Task<ApiResponse<Object>> DonorLogin(UserLoginDto donorLoginDTO);
    }
}
