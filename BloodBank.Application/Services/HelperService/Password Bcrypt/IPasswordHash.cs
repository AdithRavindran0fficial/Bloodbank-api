using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodBank.Application.Services.HelperService.Password_Bcrypt
{
    public interface IPasswordHash
    {
        string PassWordHash(string Password);
        bool VerifyPassword(string password, string Hashedpassword);
    }
}
