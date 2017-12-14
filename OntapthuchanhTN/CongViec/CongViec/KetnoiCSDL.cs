using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace CongViec
{
    class KetnoiCSDL
    {
        //khai bao
        string strConnect = @"Data Source=HOANHA;Initial Catalog=CongViec;User ID=sa;Password=123456";
        SqlConnection cn; //ket noi
        SqlCommand cmd; //truy van
        SqlDataAdapter da; //đổ dữ liệu
        DataSet ds; //đựng dữ liệu
        //truy van
        public DataSet TruyvanDL(CommandType cmdType, string cmdText, List<SqlParameter> listParam)//hien thi danh sach su dung Dataset
        {
            cn = new SqlConnection(strConnect);
            cn.Open();
            cmd = new SqlCommand();
            cmd = cn.CreateCommand();
            cmd.CommandType = cmdType;
            cmd.CommandText = cmdText;
            if (listParam != null)
            {
                foreach (var item in listParam)
                {
                    cmd.Parameters.Add(item);
                }
            }
            ds = new DataSet();
            da = new SqlDataAdapter(cmd);
            da.Fill(ds);
            cn.Close();
            return ds;
        }
        //Cập nhật DL: (Thêm, sửa xóa).
        //Chỉ Trả về kết quả true/false -> dùng bool
        public bool CapNhatDL(CommandType cmdType, string cmdText, List<SqlParameter> listParam)
        {
            bool kq= false;
               
            try
            {
                cn=new SqlConnection(strConnect);
                cn.Open();
                cmd = new SqlCommand();
                cmd = cn.CreateCommand();
                cmd.CommandType = cmdType;
                cmd.CommandText = cmdText;
                if(listParam != null){
                    foreach (var item in listParam)
                    {
                        cmd.Parameters.Add(item);
                    }
                }
                try
                {
                    cmd.ExecuteNonQuery();
                    kq = true;
                }
                    finally
                {
                    cn.Close();
                }
            }
                catch
                {
                    
                }
            return kq;
            }
        }

    }

