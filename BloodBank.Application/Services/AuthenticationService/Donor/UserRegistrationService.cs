using BloodBank.Application.Common.Response;
using BloodBank.Application.DTOs.AuthenticationDTO.DonorDTO;
using BloodBank.Application.DTOs.Base_Dtos;
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
    public class UserRegistrationService : IDonorRegistrationService
    {
        private readonly IUserRegistration donorRegistration;
        private readonly IUserValidationService userValidationService;

        public UserRegistrationService(IUserRegistration donor,IUserValidationService userValidation)
        {
            donorRegistration = donor;
            userValidationService = userValidation;
        }
        public async  Task<ApiResponse<object>> DonorRegister(UserDto donor)
        {
            try
            {
                var Age = DateTime.Now.Year-donor.DOB.Year ;
                if (donor.DOB.Date > DateTime.Now.AddYears(-Age)) Age--;
                if (Age < 18) return new ApiResponse<object>("Your not eligible to donate", 200, false);
                if (await userValidationService.IsUserExistsAsync(donor.Name, donor.Phone))
                {


                    var result = await donorRegistration.RegisterDonor(donor);
                    if (result)
                    {

                        return new ApiResponse<object>("Registration Successful", 200, true);
                    }
                    return new ApiResponse<object>("Registration Failed", 200, true);
                }
                else
                {
                    return new ApiResponse<object>("User Already exist", 200, false);


                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);

            }
        }
    }
}
