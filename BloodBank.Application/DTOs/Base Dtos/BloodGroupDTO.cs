using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodBank.Application.DTOs.Base_Dtos
{
    public interface BloodGroupDTO
    {
        public int BloodId { get; set; }
        public string BloodGroup { get; set; }
    }
}
