using BloodBank.Application.DTOs.AuthenticationDTO.DonorDTO;
using BloodBank.Application.Interfaces.IRepository.IAuthenticationRepo.IDonorRepo;
using BloodBank.Domain.Model.DonorModels;
using BloodBank.Infrastructure.DbContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodBank.Infrastructure.AuthenticationRepo.DonorRepo
{
    public class DonorRegistration : IDonorRegistration
    {
        private readonly DapperContext dapperContext;
        public DonorRegistration(DapperContext context)
        {
            dapperContext = context;
        }
        public Task<bool> RegisterDonor(DonorDto donor)
        {
            try
            {
                using(var connection = dapperContext.CreateConnection())
                {
                    var Donor = new DonorModel
                    {
                        Name = donor.Name,
                        Phone = donor.Phone,
                        BloodGroup = donor.BloodGroup,
                        Dob = donor.DOB,
                        IsAllowed = true,
                        IsBlocked = true,
                        LastDonation = null,
                        Password = donor.Password

                    };
                    //var sql = "insert into Donor values(@Name,@Phone,IsAllowed)"

                }


            }
            catch (Exception ex)
            {

            }
        }
    }
}
