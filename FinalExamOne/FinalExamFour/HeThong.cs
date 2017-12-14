using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalExamFour
{
    public partial class HeThong : Form
    {
        public HeThong()
        {
            InitializeComponent();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                this.Close();
                DangNhap frm = new DangNhap();
                frm.ShowDialog();
                //this.Show();
            }
        }

        private void loạiThuốcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoaiThuoc frm = new LoaiThuoc();
            frm.ShowDialog();
            this.Show();
        }

        private void thuốcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Thuoc frm = new Thuoc();
            frm.ShowDialog();
            this.Show();
        }

        private void thốngKêToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            ThongKe frm = new ThongKe();
            frm.ShowDialog();
            this.Show();
        }
    }
}
