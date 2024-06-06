using Backend.Models;
using Backend.Repositories.Interfaces;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
using System.Data;
using Dapper;
using Backend.Context;

namespace Backend.Repositories.Data
{
    public class AssetRepository : IAssetRepository
    {
        private readonly DapperDBConteks context;
        public AssetRepository(DapperDBConteks context) 
        {
            this.context = context;
        }

        public int Delete(int Id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TblProduct> Get()
        {
            var spName = "Sp_GetAsset"; //untuk nama storedProcedure
            var vParams = new DynamicParameters();
            var get = context.CreateConnection().Query<TblProduct>(spName, commandType: CommandType.StoredProcedure); //connection.Query untuk Get, untuk .Exucute(spName, commandType) untuk insert
            return get;

        }

        public TblProduct Get(int Id)
        {
            throw new NotImplementedException();
        }

        public int Insert(TblProduct asset)
        {
            throw new NotImplementedException();
        }

        public int Update(TblProduct asset)
        {
            throw new NotImplementedException();
        }
    }
}
