using BloodBank.Application.Common.Response;
using BloodBank.Application.DTOs.AuthenticationDTO.DonorDTO;
using BloodBank.Application.Interfaces.IServices.IAuthenticationService.Donor;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BloodDonation.Controllers.Authentication_Controller.Donor
{
    [Route("api/Donor")]
    [ApiController]
    public class DonorRegistrationController : ControllerBase
    {
        private readonly IDonorRegistrationService donorRegistration;
        public DonorRegistrationController(IDonorRegistrationService registrationService)
        {
            donorRegistration = registrationService;
            
        }
        [HttpPost]
        public async Task<IActionResult> RegisterDonor(DonorDto donor)
        {
            try
            {
                var result = await donorRegistration.DonorRegister(donor);
                return Ok(result);

            }catch(Exception ex)
            {
                return StatusCode(500,new ApiResponse<object>("Internal Server error", 500));

            }
        }
    }
}
