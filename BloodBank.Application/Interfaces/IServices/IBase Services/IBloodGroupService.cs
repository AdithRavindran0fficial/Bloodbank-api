using BloodBank.Application.Common.Response;
using BloodBank.Application.DTOs.Base_Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodBank.Application.Interfaces.IServices.IBase_Services
{
    public interface IBloodGroupService
    {
        Task<ApiResponse<List<BloodGroupDTO>>> GetBloodGroups();
    }
}
