using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using UOM.Interface.Facade.Contracts;
using UOM.QueryModel.Model;

namespace UOM.Interface.Facade.Query
{
    public class MeasurementDimensionFacadeQuery : IMeasurementDimensionFacadeQuery
    {
        //private IDbConnection _connection;
        //public MeasurementDimensionFacadeQuery(IDbConnection connection)
        //{
        //    this._connection = connection;
        //}

        public async Task<MeasurementDimensionQuery> GetBySymbol(string symbol)
        {
            //TODO: use castle windsor to inject the connection !
            var connectionString = ConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString;
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                var sql = "SELECT * from MeasurementDimensions WHERE Symbol=@sym";
                var data =  await connection.QueryFirstOrDefaultAsync<MeasurementDimensionQuery>(sql, new { sym = symbol });
                return data;
            }
        }
    }
}
