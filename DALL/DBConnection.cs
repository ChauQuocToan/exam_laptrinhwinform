using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBH_Chauquoctoan.DALL
{
    public class DBConnection
    {
        public DBConnection()
        {
        }
        public SqlConnection CreateConnection()
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Data Source= DESKTOP-RSMF0P1\MSSQLSERVER3 ;Initial Catalog= TaiKhoan; User Id=sa; Password=sa";
            return conn;
        }
    }
}
