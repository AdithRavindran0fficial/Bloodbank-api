using BloodBank.Application.Interfaces.IRepository.IBaseRepo;
using BloodBank.Domain.Model.Base_Models;
using BloodBank.Infrastructure.DbContext;
using Dapper;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodBank.Infrastructure.Base_Repository
{
    public class BloodGroupRepository : IBloodGroupRepository
    {
        private readonly DapperContext dapperContext; 
        public BloodGroupRepository(DapperContext context)
        {
            dapperContext = context;
        }
        public async Task<IEnumerable< BloodGroupModel?>> GetBloodGroupsAsync()
        {
            try
            {
                using(var connection = dapperContext.CreateConnection())
                {
                    var sql = "select * from BloodGroup";
                    var bloodgrp = await connection.QueryAsync<BloodGroupModel>(sql);
                    return bloodgrp;
                }
                
            }
            catch(Exception ex)
            {
                Debug.WriteLine(ex.Message);
                return null;
            }
           
        }
    }
}
