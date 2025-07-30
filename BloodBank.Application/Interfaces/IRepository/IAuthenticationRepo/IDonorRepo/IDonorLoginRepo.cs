using BloodBank.Application.DTOs.AuthenticationDTO.DonorDTO;
using BloodBank.Domain.Model.DonorModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodBank.Application.Interfaces.IRepository.IAuthenticationRepo.IDonorRepo
{
    public  interface IDonorLoginRepo
    {
        Task<UserModel?>Login(UserLoginDto donor);
    }
}
