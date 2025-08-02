using BloodBank.Application.DTOs.AuthenticationDTO.DonorDTO;
using BloodBank.Application.Interfaces.IRepository.IAuthenticationRepo.IDonorRepo;
using BloodBank.Application.Services.HelperService.Password_Bcrypt;
using BloodBank.Domain.Model.DonorModels;
using BloodBank.Infrastructure.DbContext;
using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodBank.Infrastructure.AuthenticationRepo
{
    public class UserRegistration : IUserRegistration
    {
        private readonly DapperContext dapperContext;
        private readonly IPasswordHash passwordHash;
        public UserRegistration(DapperContext context,IPasswordHash password)
        {
            dapperContext = context;
            passwordHash = password;
        }
        public async Task<bool> RegisterDonor(UserDto donor)
        {
            try
            {
                using(var connection = dapperContext.CreateConnection())
                {
                    var Donor = new UserModel
                    {
                        Name = donor.Name,
                        Phone = donor.Phone,
                        BloodGroup = donor.BloodGroup,
                        Dob = donor.DOB,
                        IsAllowed = true,
                        IsBlocked = false,
                        LastDonation = null,
                        Password = passwordHash.PassWordHash(donor.Password),
                        CreatedAt = DateTime.UtcNow,
                        RoleId = donor.RoleId

                    };
                 

                 
                    var sql = "INSERT INTO Donor VALUES (@Name, @Phone, @IsAllowed, @CreatedAt, @LastDonation, @IsBlocked, @Dob,@BloodGroup,@Password)";
                    var result = await  connection.ExecuteAsync(sql, Donor);
                    return result>0;
                }


            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
                
            }
        }
    }
}
