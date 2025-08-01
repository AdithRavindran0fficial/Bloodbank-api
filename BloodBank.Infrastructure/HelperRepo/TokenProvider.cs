using BloodBank.Application.Interfaces.IServices.IHelperService;
using BloodBank.Domain.Model.DonorModels;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.JsonWebTokens;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BloodBank.Application.Services.HelperService
{
    class TokenProvider : ITokenProvider
    {
        private  readonly string SecretKey;
        private readonly IConfiguration _configuration;
        public TokenProvider(IConfiguration configure)
        {
            SecretKey = configure["JwtConfig:Key"];
            _configuration = configure;
        }
        public string GetToken(UserModel user)
        {
            try
            {
                var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(SecretKey));

                var Credantial = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);
                var Tokendescriptor = new SecurityTokenDescriptor
                {
                    Subject = new ClaimsIdentity([
                        new Claim(JwtRegisteredClaimNames.Sub,user.ID.ToString()),
                        new Claim(JwtRegisteredClaimNames.Sub,user.Phone)
                        ]),
                    Expires = DateTime.UtcNow.AddMinutes(60),
                    SigningCredentials = Credantial,
                    
                };
                var tokenHandler = new JsonWebTokenHandler();
                var token = tokenHandler.CreateToken(Tokendescriptor);
                return token;

            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
                
            }
        }
    }
}
