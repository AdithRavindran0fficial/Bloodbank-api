using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodBank.Application.DTOs.AuthenticationDTO.UserDTO
{
    public class LoginResponse
    {
        public string Token { get; set; }
        public long Token_ExpiresIn { get; set; }
        
    }
}
