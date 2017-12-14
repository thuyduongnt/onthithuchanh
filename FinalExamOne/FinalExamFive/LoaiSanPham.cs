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

namespace FinalExamFive
{
    public partial class LoaiSanPham : Form
    {
        public LoaiSanPham()
        {
            InitializeComponent();
        }

        private void LoaiSanPham_Load(object sender, EventArgs e)
        {
            getData();
        }

        public void getData()
        {
            SqlConnection conn = new SqlConnection(@"Data Source=HP\DUONGNGUYEN;Initial Catalog=Banhang5;Integrated Security=True");
            string query = "select * from LoaiSanPham order by MaLoaiSP";
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            DataSet ds = new DataSet();
            da.Fill(ds, "LoaiSanPham");
            dgvLoaisp.DataSource = ds.Tables["LoaiSanPham"];
        }
    }
}
