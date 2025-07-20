using BloodBank.Application.Common.Response;
using BloodBank.Application.DTOs.Base_Dtos;
using BloodBank.Application.Interfaces.IRepository.IBaseRepo;
using BloodBank.Application.Interfaces.IServices.IBase_Services;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodBank.Application.Services.BaseService
{
    public class BloodGroupService : IBloodGroupService
    {
        private readonly IBloodGroupRepository groupRepository;
        public BloodGroupService(IBloodGroupRepository repository)
        {
            groupRepository = repository;

        }
        public async Task<ApiResponse<List<BloodGroupDTO>>?> GetBloodGroups()
        {
            try
            {
                var result = await groupRepository.GetBloodGroupsAsync();
                if(result!=null && result.Any())
                {
                    var dto = result.Select(s => new BloodGroupDTO
                    {
                        BloodGroup = s.BloodGroup,
                        BloodId = s.BloodId
                    }).ToList();
                    return new ApiResponse<List<BloodGroupDTO>>("success", 200, true, dto);
                }
                return new ApiResponse<List<BloodGroupDTO>>("No blood groups found", 200,false);

            }
            catch(Exception ex)
            {
                Debug.WriteLine(ex.Message);
                return new ApiResponse<List<BloodGroupDTO>>("Internal Server error", 500,false);
            }
        }
    }
}
