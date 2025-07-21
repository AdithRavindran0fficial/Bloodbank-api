using BloodBank.Application.Interfaces.IRepository.IHelperRepo;
using BloodBank.Application.Interfaces.IServices.IHelperService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodBank.Application.Services.HelperService
{
    public class UserValidationService : IUserValidationService
    {
        IUserValidationRepo _repo;
        public UserValidationService(IUserValidationRepo userValidation)
        {
            _repo = userValidation;
        }

        public Task<bool> IsUserExistsAsync(string UserName, string phone)
        {
            throw new NotImplementedException();
        }
    }
}
