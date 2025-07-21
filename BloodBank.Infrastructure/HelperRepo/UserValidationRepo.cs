using BloodBank.Application.Interfaces.IRepository.IHelperRepo;
using BloodBank.Infrastructure.DbContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodBank.Infrastructure.HelperRepo
{
    public class UserValidationRepo : IUserValidationRepo
    {
        private readonly DapperContext dbContext;
        public UserValidationRepo(DapperContext context)
        {

            dbContext = context;
        }

        public Task<bool> IsUserExits(string UserName, string Phone)
        {
            throw new NotImplementedException();
        }
    }
}
