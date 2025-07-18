using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodBank.Domain.Model.DonorModels
{
    public  class DonorModel
    {
        public int ID { get; set; }
        public string? Name { get; set; }
        public string ? Phone { get;set; }
        public DateTime? Dob { get; set; }
        public int BloodGroup {  get; set; }
        public DateTime? LastDonation { get; set; }
       public bool IsAllowed { get; set; }  
        public bool IsBlocked { get; set; } 
        public string? Password { get; set; }

    }
}
