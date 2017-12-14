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
    public partial class Hethong : Form
    {
        public Hethong()
        {
            InitializeComponent();
        }

        private void đăngNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DangNhap login = new DangNhap();
            login.Show();

        }

        private void loạiCôngViệcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoaiCongViec loaicv = new LoaiCongViec();
            loaicv.Show();
        }

        private void côngViệcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CongViec cv = new CongViec();
            cv.Show();
        }
    }
}
