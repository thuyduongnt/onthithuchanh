using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai2_de1
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            DB data = new DB();
            string user = txt_user.Text;
            string pass = txt_pass.Text;
            string sql_user = "Select TaiKhoan, MatKhau from Nguoidung where TaiKhoan ='"+user+"' and MatKhau = '"+pass+"' ";
            DataSet ds_user = new DataSet();
            ds_user = data.get(sql_user);
            if (ds_user.Tables[0].Rows.Count > 0)
            {
                Form1 f1 = new Form1();
                f1.Show();
            }
            else
            {
                MessageBox.Show("Đăng nhập không thành công");
            }
        }
    }
}
