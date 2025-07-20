using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodBank.Application.DTOs.AuthenticationDTO.DonorDTO
{
    public class DonorDto
    {

        [Required]
        public string? Name { get; set; }
        [Required]
        public DateTime DOB { get; set; }
        [Required]
        public int BloodGroup { get; set; }
        [Required]
        [MinLength(8)]
        public string? Password { get; set; }
        [Required]
        [StringLength(10)]
        public string ? Phone { get; set; }
      
    }
}
