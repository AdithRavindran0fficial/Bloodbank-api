using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodBank.Application.DTOs.AuthenticationDTO.DonorDTO
{
    public  class DonorLoginDTO
    {
        public string? Phone { get; set; }
        public string? Password { get; set; }    
    }
}
