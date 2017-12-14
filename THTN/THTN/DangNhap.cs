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
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }

        private void DangNhap_Load(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có muốn thoát?", "Thông báo?", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void btnDangnhap_Click(object sender, EventArgs e)
        {
            //select count(*) from Nguoidung where TaiKhoan = 'admin' and MatKhau = 'admin'
            //

            //B1: Khoi tao ket noi
            SqlConnection conn = new SqlConnection(@"Data Source=HP\DUONGNGUYEN;Initial Catalog=NhanVien;Integrated Security=True");
            //B2: Mo ket noi
            conn.Open();
            //B3: Tao truy van
            SqlCommand cmd = new SqlCommand("select count(*) from Nguoidung where TaiKhoan = '" + txtTaiKhoan.Text + "' and MatKhau = '" + txtMatKhau.Text + "'", conn);
            //B4: Thuc thi truy van
            int SoLuong = (int)cmd.ExecuteScalar();
            //B5: Dong ket noi
            conn.Close();
            //B6: Kiem tra so luong
            if (SoLuong == 1)
            {
                MessageBox.Show("Đăng nhập thành công!");
                HeThong frm = new HeThong();
                this.Hide();
                frm.Show();
            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại");
            }
        }
    }
}
