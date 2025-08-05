using BloodBank.Application.DTOs.AuthenticationDTO.DonorDTO;
using BloodBank.Application.Interfaces.IServices.IAuthenticationService.Donor;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BloodDonation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserLoginController : ControllerBase
    {
        private readonly IUserLoignService userLoignService;
        public UserLoginController(IUserLoignService loginService)
        {
            userLoignService = loginService;
        }
        [HttpPost]
        public async Task<IActionResult>LoginAsync(UserLoginDto user)
        {
            try
            {
                var result = userLoignService.DonorLogin(user);

            }
        }
    }
}
