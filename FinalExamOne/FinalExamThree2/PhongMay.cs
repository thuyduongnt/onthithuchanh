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

namespace FinalExamThree2
{
    public partial class PhongMay : Form
    {
        public PhongMay()
        {
            InitializeComponent();
        }

        private void PhongMay_Load(object sender, EventArgs e)
        {
            getData();
            getCmbLoaiPhong();
            refresh();
        }

        public void getData()
        {
            SqlConnection conn = new SqlConnection(@"Data Source=HP\DUONGNGUYEN;Initial Catalog=PhongMay;Integrated Security=True");
            string query = "select * from PhongMay";
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            DataSet ds = new DataSet();
            da.Fill(ds, "PhongMay");
            dgvPhongmay.DataSource = ds.Tables["PhongMay"];
        }

        public void getCmbLoaiPhong()
        {
            SqlConnection conn = new SqlConnection(@"Data Source=HP\DUONGNGUYEN;Initial Catalog=PhongMay;Integrated Security=True");
            string query = "select * from LoaiPhong order by TenLoaiPhong asc";
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            DataSet ds = new DataSet();
            da.Fill(ds, "LoaiPhong");
            cmbLoaiphong.DataSource = ds.Tables["LoaiPhong"];
            cmbLoaiphong.DisplayMember = "TenLoaiPhong";
            cmbLoaiphong.ValueMember = "MaLoaiP";
        }

        public void refresh()
        {
            txtMaPM.Text = "";
            txtMaPM.Enabled = true;
            txtTenPM.Text = "";
            nbSoluong.Value = 0;
            txtDiadiem.Text = "";
            txtTinhtrang.Text = "";

            btnThem.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=HP\DUONGNGUYEN;Initial Catalog=PhongMay;Integrated Security=True");
            string query = "select * from PhongMay where MaLoaiP in (select MaLoaiP from LoaiPhong where MaLoaiP like '%' + N'" + txtTimkiem.Text + "' + '%' or TenLoaiPhong like '%' + N'" + txtTimkiem.Text + "' + '%')";
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            DataSet ds = new DataSet();
            da.Fill(ds, "PhongMay");
            dgvPhongmay.DataSource = ds.Tables["PhongMay"];
        }

        private void dgvPhongmay_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            if (row >= 0)
            {
                txtMaPM.Text = dgvPhongmay.Rows[row].Cells["MaPM"].Value.ToString();
                txtTenPM.Text = dgvPhongmay.Rows[row].Cells["TenPM"].Value.ToString();
                nbSoluong.Value = decimal.Parse(dgvPhongmay.Rows[row].Cells["Soluongmay"].Value.ToString());
                txtDiadiem.Text = dgvPhongmay.Rows[row].Cells["Diadiem"].Value.ToString();
                txtTinhtrang.Text = dgvPhongmay.Rows[row].Cells["TinhTrang"].Value.ToString();
                cmbLoaiphong.SelectedValue = dgvPhongmay.Rows[row].Cells["MaLoaiP"].Value.ToString();

                txtMaPM.Enabled = false;
                btnThem.Enabled = false;
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
            }
        }

        private void btnLammoi_Click(object sender, EventArgs e)
        {
            refresh();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=HP\DUONGNGUYEN;Initial Catalog=PhongMay;Integrated Security=True");
            conn.Open();
            string query = "insert into PhongMay(MaPM,TenPM,Soluongmay,Diadiem,TinhTrang,MaLoaiP) values(N'" + txtMaPM.Text + "',N'" + txtTenPM.Text + "','" + nbSoluong.Value + "',N'" + txtDiadiem.Text + "',N'" + txtTinhtrang.Text + "',N'" + cmbLoaiphong.SelectedValue.ToString() + "')";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Thêm dữ liệu thành công!", "Thông báo");
            getData();
            refresh();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=HP\DUONGNGUYEN;Initial Catalog=PhongMay;Integrated Security=True");
            conn.Open();
            string query = "update PhongMay set TenPM=N'" + txtTenPM.Text + "', Soluongmay='" + nbSoluong.Value + "', Diadiem=N'" + txtDiadiem.Text + "', TinhTrang=N'" + txtTinhtrang.Text + "', MaLoaiP=N'" + cmbLoaiphong.SelectedValue.ToString() + "' where MaPM=N'" + txtMaPM.Text + "'";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Sửa dữ liệu thành công!", "Thông báo");
            getData();
            refresh();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                SqlConnection conn = new SqlConnection(@"Data Source=HP\DUONGNGUYEN;Initial Catalog=PhongMay;Integrated Security=True");
                conn.Open();
                string query = "delete from PhongMay where MaPM='" + txtMaPM.Text + "'";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Xóa dữ liệu thành công!", "Thông báo");
                getData();
                refresh();
            }
            
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                this.Close();
            }
        }

    }
}
