using BloodBank.Application.DTOs.AuthenticationDTO.DonorDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodBank.Application.Interfaces.IRepository.IAuthenticationRepo.IDonorRepo
{
    public  interface IDonorRegistration
    {
        Task<bool> RegisterDonor(DonorDto donor);
    }
}
