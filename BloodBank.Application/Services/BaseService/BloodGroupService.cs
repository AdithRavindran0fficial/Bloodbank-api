using BloodBank.Application.DTOs.Base_Dtos;
using BloodBank.Application.Interfaces.IServices.IBase_Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodBank.Application.Services.BaseService
{
    public class BloodGroupService : IBloodGroupService
    {
        public Task<BloodGroupDTO?> GetBloodGroups()
        {
            throw new NotImplementedException();
        }
    }
}
