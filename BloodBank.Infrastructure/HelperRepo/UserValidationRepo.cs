using BloodBank.Application.Interfaces.IRepository.IHelperRepo;
using BloodBank.Domain.Model.DonorModels;
using BloodBank.Infrastructure.DbContext;
using Dapper;
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

        public async Task<bool> IsUserExits(string UserName, string Phone)
        {
            try
            {
                using (var connection = dbContext.CreateConnection())
                {
                    var sql = "select * from Donor where Phone=@Phone";
                    var result = await connection.QueryFirstOrDefaultAsync<DonorModel>(sql, new { Phone = Phone });
                    if (result != null)
                    {
                        return false;
                    }
                    return true;

                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
