﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace THTN
{
    public partial class HeThong : Form
    {
        public HeThong()
        {
            InitializeComponent();
        }

        private void HeThong_Load(object sender, EventArgs e)
        {

        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void loạiNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLoaiNhanVien frm = new frmLoaiNhanVien();
            frm.ShowDialog();
        }

        private void thốngKêToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void lươngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLuong frm = new frmLuong();
            frm.ShowDialog();
        }
    }
}
