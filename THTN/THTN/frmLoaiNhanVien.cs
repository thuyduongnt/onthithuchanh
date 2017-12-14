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

namespace THTN
{
    public partial class frmLoaiNhanVien : Form
    {
        public frmLoaiNhanVien()
        {
            InitializeComponent();
        }

        private void frmLoaiNhanVien_Load(object sender, EventArgs e)
        {
            getData();
        }

        public void getData()
        {
            //B1: Khoi tao ket noi
            SqlConnection conn = new SqlConnection(@"Data Source=HP\DUONGNGUYEN;Initial Catalog=NhanVien;Integrated Security=True");
            //B2: Khoi tao truy van
            string query = "select * from LoaiNhanVien order by TenLoaiNV asc";
            //B3: Thuc thi truy van
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            //B4: Khoi tao DataSet
            DataSet ds = new DataSet();
            //B5: Do du lieu len DataSet thong qua phuong thuc Fill()
            da.Fill(ds, "LoaiNhanVien");
            //B6: Hien thi du lieu len DataDridView
            dgvLoaiNhanVien.DataSource = ds.Tables["LoaiNhanVien"];
        }
    }
}
