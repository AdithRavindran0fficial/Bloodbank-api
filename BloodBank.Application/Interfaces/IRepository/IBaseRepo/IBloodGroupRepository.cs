using BloodBank.Domain.Model.Base_Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodBank.Application.Interfaces.IRepository.IBaseRepo
{
    public interface IBloodGroupRepository
    {
        Task<IEnumerable< BloodGroupModel?>> GetBloodGroupsAsync();
    }
}
