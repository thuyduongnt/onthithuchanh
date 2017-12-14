using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalExamTwo
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
                Application.Exit();
            }
        }

        private void mônHọcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            MonHoc frm = new MonHoc();
            frm.ShowDialog();
            this.Show();
        }

        private void điểmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Diem frm = new Diem();
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
