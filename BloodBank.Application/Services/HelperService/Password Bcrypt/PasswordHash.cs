using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodBank.Application.Services.HelperService.Password_Bcrypt
{
    public class PasswordHash : IPasswordHash
    {
        public string PassWordHash(string Password)
        {
            try
            {

                return BCrypt.Net.BCrypt.HashPassword(Password);
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public bool VerifyPassword(string password, string Hashedpassword)
        {
            try
            {
                return BCrypt.Net.BCrypt.Verify(password, Hashedpassword);

            }
            catch(Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
