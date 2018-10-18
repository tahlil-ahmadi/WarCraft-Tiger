using System;
using System.Collections.Generic;
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

        public MeasurementDimensionQuery GetBySymbol(string symbol)
        {
            using (var connection = new SqlConnection(@"Data Source=CLASS1-TEACHER\MSSQLSERVER1;Initial Catalog=TigerDB;Integrated Security=True"))
            {
                connection.Open();
                var sql = "SELECT * from MeasurementDimensions WHERE Symbol=@sym";
                var data =  connection.QueryFirstOrDefault<MeasurementDimensionQuery>(sql, new { sym = symbol });
                return data;
            }
        }
    }
}
