using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalExamTwo
{
    public partial class MonHoc : Form
    {
        public MonHoc()
        {
            InitializeComponent();
        }

        private void MonHoc_Load(object sender, EventArgs e)
        {
            getData();
        }

        public void getData()
        {
            //B1: Tao ket noi
            SqlConnection conn = new SqlConnection(@"Data Source=HP\DUONGNGUYEN;Initial Catalog=Banhang;Integrated Security=True");
            //B2: Tao truy van
            string query = "select * from Monhoc order by TenMH asc";
            //B3: Thuc thi truy van
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            //B4: Khoi tao DataSet
            DataSet ds = new DataSet();
            //B5: Do du lieu len DataSet thong qua phuong thuc Fill()
            da.Fill(ds, "Monhoc");
            //B6: Do du lieu len gridview
            dgvMonhoc.DataSource = ds.Tables["Monhoc"];
        }
    }
}
