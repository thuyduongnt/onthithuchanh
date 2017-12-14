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

namespace FinalExamFour
{
    public partial class LoaiThuoc : Form
    {
        public LoaiThuoc()
        {
            InitializeComponent();
        }

        private void LoaiThuoc_Load(object sender, EventArgs e)
        {
            getData();
        }

        public void getData()
        {
            SqlConnection conn = new SqlConnection(@"Data Source=HP\DUONGNGUYEN;Initial Catalog=BanThuoc;Integrated Security=True");
            string query = "select * from LoaiThuoc order by MaLoaiT";
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            DataSet ds = new DataSet();
            da.Fill(ds, "LoaiThuoc");
            dgvLoaiThuoc.DataSource = ds.Tables["LoaiThuoc"];
        }
    }
}
