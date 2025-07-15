using BloodBank.Application.Interfaces.IServices.IBase_Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BloodDonation.Controllers.Base_Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BloodGroupsController : ControllerBase
    {
        private readonly IBloodGroupService groupService;
        public BloodGroupsController(IBloodGroupService bloodGroupService)
        {
            groupService = bloodGroupService;

        }

    }
}
