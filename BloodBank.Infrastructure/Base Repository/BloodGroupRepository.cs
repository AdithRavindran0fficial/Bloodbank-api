using BloodBank.Application.Interfaces.IRepository.IBaseRepo;
using BloodBank.Domain.Model.Base_Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodBank.Infrastructure.Base_Repository
{
    public class BloodGroupRepository : IBloodGroupRepository
    {
        public Task<BloodGroupModel?> GetBloodGroupsAsync()
        {
            throw new NotImplementedException();
        }
    }
}
