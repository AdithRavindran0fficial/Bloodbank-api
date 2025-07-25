﻿using BloodBank.Application.Common.Response;
using BloodBank.Application.DTOs.AuthenticationDTO.DonorDTO;
using BloodBank.Application.Interfaces.IRepository.IAuthenticationRepo.IDonorRepo;
using BloodBank.Application.Interfaces.IServices.IAuthenticationService.Donor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodBank.Application.Services.AuthenticationService.Donor
{
    public class DonorLoginService : IDonorLoignService
    {
        private readonly IDonorLoginRepo donorLogin; 
        public DonorLoginService(IDonorLoginRepo donorLoginRepo)
        {
            donorLogin = donorLoginRepo;
        }
        public async Task<ApiResponse<object>> DonorLogin(DonorLoginDTO donor)
        {
            try
            {
                

                var result =await  donorLogin.Login(donor);
                if (result == null)
                {
                    return new ApiResponse<object>("user not  found", 401, true);
                }
                else
                {
                    return new ApiResponse<object>("user  found", 200, true);

                }
            }
            catch(Exception ex)
            {
                return new ApiResponse<object>(ex.Message, 500, false);

            }
        }
    }
}
