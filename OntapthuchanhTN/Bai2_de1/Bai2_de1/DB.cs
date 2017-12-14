using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2_de1
{
    class DB
    {
        SqlConnection con;
        SqlDataAdapter da;
        DataSet ds;
        string SqlString = @"Data Source=HOANHA;Initial Catalog=CongViec;User ID=sa;Password=123456";
        public void Connect()
        {
            if (con == null)
            {
                con = new SqlConnection(SqlString);
                if (con.State == ConnectionState.Closed)
                {
                    con.Close();
                }


            }
        }
        public void Disconnect()
        {
            if ((con != null) && (con.State == ConnectionState.Open))
            {
                con.Close();
            }
        }
        public DataSet get(string SQL)
        {
            Connect();
            da = new SqlDataAdapter(SQL, con);//cau noi sql và con
            ds = new DataSet();
            da.Fill(ds);//đổ dữ liệu da vào ds
            Disconnect();
            return ds;
        }

    }
    
}
