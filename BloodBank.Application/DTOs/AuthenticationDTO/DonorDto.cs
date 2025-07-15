using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodBank.Application.DTOs.AuthenticationDTO
{
    public class DonorDto
    {
        [Required]
        public string? FullName { get; set; }

        [Required]
        [Phone]
        public string? Phone { get; set; }

        [Required]
        [MinLength(8)]
        public string? Password { get; set; }
    }
}
