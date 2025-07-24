using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodBank.Application.DTOs.AuthenticationDTO.DonorDTO
{
    public class DonorLoginDTO
    {
        [Required]
        public string? Phone { get; set; }

        [Required]
        public string? Password { get; set; }
    }
}
