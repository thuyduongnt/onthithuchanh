using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CongViec
{
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }

        private void btn_dangnhap_Click(object sender, EventArgs e)
        {
            //ket noi csdl
            KetnoiCSDL kn = new KetnoiCSDL();
            DataSet ds = new DataSet();
            ds = kn.TruyvanDL(CommandType.Text, "Select * from Nguoidung where TaiKhoan='"+txt_User.Text+"' and MatKhau ='"+txt_Pass.Text+"' ", null);
            if (ds.Tables[0].Rows.Count > 0)
            {
                MessageBox.Show("Đăng nhập thành công");
                Hethong ht = new Hethong();
                ht.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại");
            }
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
