using BloodBank.Application.Common.Response;
using BloodBank.Application.DTOs.AuthenticationDTO.DonorDTO;
using BloodBank.Application.DTOs.Base_Dtos;
using BloodBank.Application.Interfaces.IRepository.IAuthenticationRepo.IDonorRepo;
using BloodBank.Application.Interfaces.IServices.IAuthenticationService.Donor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodBank.Application.Services.AuthenticationService.Donor
{
    public class DonorRegistrationService : IDonorRegistrationService
    {
        private readonly IDonorRegistration donorRegistration;
        public DonorRegistrationService(IDonorRegistration donor)
        {
            donorRegistration = donor;
        }
        public async  Task<ApiResponse<object>> DonorRegister(DonorDto donor)
        {
            try
            {
                var result = await donorRegistration.RegisterDonor(donor);
                if (result)
                {
                    return new ApiResponse<object>("Registration Successful", 200);
                }
                return new ApiResponse<object>("Registration Failed", 200);

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);

            }
        }
    }
}
