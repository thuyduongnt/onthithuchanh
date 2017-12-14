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

namespace FinalExamThree2
{
    public partial class LoaiPhong : Form
    {
        public LoaiPhong()
        {
            InitializeComponent();
        }

        private void LoaiPhong_Load(object sender, EventArgs e)
        {
            getData();
        }

        public void getData()
        {
            SqlConnection conn = new SqlConnection(@"Data Source=HP\DUONGNGUYEN;Initial Catalog=PhongMay;Integrated Security=True");
            string query = "select * from LoaiPhong order by TenLoaiPhong asc";
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            DataSet ds = new DataSet();
            da.Fill(ds, "LoaiPhong");
            dgvLoaiphong.DataSource = ds.Tables["LoaiPhong"];
        }
    }
}
