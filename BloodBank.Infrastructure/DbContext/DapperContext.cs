﻿using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodBank.Infrastructure.DbContext
{
    public class DapperContext
    {
        IConfiguration _configuration;
        private readonly string? _connectionString;
        public DapperContext(IConfiguration configuration )
        {
           _configuration = configuration;
            _connectionString = configuration.GetConnectionString("SqlConnection");
        }

        public IDbConnection CreateConnection()
            => new SqlConnection( _connectionString);
       
    }
}
