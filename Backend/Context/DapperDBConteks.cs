using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace Backend.Context;

public partial class DapperDBConteks : DbContext
{
    private readonly IConfiguration _configuration;
    private readonly string connectionString;
    public DapperDBConteks(IConfiguration configuration)
    {
        _configuration = configuration;
        connectionString = _configuration.GetConnectionString("AssetsProjectContext");
    }

    public IDbConnection CreateConnection() => new SqlConnection(connectionString);
}
