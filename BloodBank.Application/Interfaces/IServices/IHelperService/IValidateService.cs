﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodBank.Application.Interfaces.IServices.IHelperService
{
   public interface IValidateService
    {
        Task<bool> ValidatePhone();
    }
}
