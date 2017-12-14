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
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }

        
        private void FormDangNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("Bạn có thực sự muốn thoát?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //B1: Khởi tạo kết nối
            SqlConnection conn = new SqlConnection(@"Data Source=HP\DUONGNGUYEN;Initial Catalog=CongViec;Integrated Security=True");
            //B2: Mở kết nối
            conn.Open();
            //B3: Tạo truy vấn
            SqlCommand cmd = new SqlCommand("select count(*) from Nguoidung where Taikhoan = '" + txtTaikhoan.Text + "' and Matkhau = '" + txtMatkhau.Text + "'", conn);
            //B4: Thực thi truy vấn
            int soluong = (int)cmd.ExecuteScalar();
            //B5: Đóng kết nối
            conn.Close();
            //B6: Kiểm tra số lượng
            if (soluong == 1)
            {
                MessageBox.Show("Đăng nhập thành công!", "Thông báo");
                HeThong frm = new HeThong();
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại!", "Thông báo");
                txtTaikhoan.Focus();
            }
        }

        
    }
}
