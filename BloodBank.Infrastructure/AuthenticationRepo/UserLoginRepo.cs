using BloodBank.Application.DTOs.AuthenticationDTO.DonorDTO;
using BloodBank.Application.Interfaces.IRepository.IAuthenticationRepo.IDonorRepo;
using BloodBank.Domain.Model.DonorModels;
using BloodBank.Infrastructure.DbContext;
using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace BloodBank.Infrastructure.AuthenticationRepo
{
    public class UserLoginRepo : IDonorLoginRepo
    {
        DapperContext context;
        public UserLoginRepo(DapperContext dapperContext)
        {

            context = dapperContext;
        }

        public async Task<UserModel?> Login(UserLoginDto donor)
        {
            try
            {
                using (var connection = context.CreateConnection())
                {
                    var sql = "select * from Users where Phone = @phone";
                    var result = await connection.QueryFirstOrDefaultAsync<UserModel?>(sql, new { phone = donor.Phone });
                    return result;



                }


            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        
    }
}
