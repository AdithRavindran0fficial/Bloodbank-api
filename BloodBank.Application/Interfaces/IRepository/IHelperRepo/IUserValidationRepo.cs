using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodBank.Application.Interfaces.IRepository.IHelperRepo
{
    public  interface IUserValidationRepo
    {
        Task<bool> IsUserExits(string UserName, string Phone);

    }
}
