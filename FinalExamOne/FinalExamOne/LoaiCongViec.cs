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

namespace FinalExamOne
{
    public partial class LoaiCongViec : Form
    {
        public LoaiCongViec()
        {
            InitializeComponent();
        }

        private void LoaiCongViec_Load(object sender, EventArgs e)
        {
            getData();
        }

        public void getData()
        {
            //B1: Tao ket noi csdl
            SqlConnection conn = new SqlConnection(@"Data Source=HP\DUONGNGUYEN;Initial Catalog=CongViec;Integrated Security=True");
            //B2: Tao truy van 
            string query = "select * from LoaiCV order by TenLoaiCV asc";
            //B3: Thuc thi truy van
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            //B4: Khoi tao DataSet
            DataSet ds = new DataSet();
            //B5: Do du lieu len DataSet thong qua phuong thuc Fill()
            da.Fill(ds, "LoaiCV");
            //B6: Hien thi du lieu len dataGridView
            dgvLoaiCV.DataSource = ds.Tables["LoaiCV"];
        }
    }
}
