﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalExamThree2
{
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }

        private void btnDangnhap_Click(object sender, EventArgs e)
        {
            //Data Source=HP\DUONGNGUYEN;Initial Catalog=PhongMay;Integrated Security=True
            SqlConnection conn = new SqlConnection(@"Data Source=HP\DUONGNGUYEN;Initial Catalog=PhongMay;Integrated Security=True");
            conn.Open();
            string query = "select count(*) from Nguoidung where Taikhoan='" + txtTaikhoan.Text + "' and Matkhau='" + txtMatkhau.Text + "'";
            SqlCommand cmd = new SqlCommand(query, conn);
            int soluong = (int)cmd.ExecuteScalar();
            conn.Close();
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

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                Application.Exit();
            }
        }
    }
}
