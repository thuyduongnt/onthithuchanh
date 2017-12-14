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

namespace FinalExamFour
{
    public partial class Thuoc : Form
    {
        public Thuoc()
        {
            InitializeComponent();
        }

        private void Thuoc_Load(object sender, EventArgs e)
        {
            getData();
            getCmbLoaiThuoc();
            LamMoi();
        }

        public void getData()
        {
            SqlConnection conn = new SqlConnection(@"Data Source=HP\DUONGNGUYEN;Initial Catalog=BanThuoc;Integrated Security=True");
            string query = "select * from Thuoc order by TenThuoc";
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            DataSet ds = new DataSet();
            da.Fill(ds, "Thuoc");
            dgvThuoc.DataSource = ds.Tables["Thuoc"];
        }

        public void getCmbLoaiThuoc()
        {
            SqlConnection conn = new SqlConnection(@"Data Source=HP\DUONGNGUYEN;Initial Catalog=BanThuoc;Integrated Security=True");
            string query = "select * from LoaiThuoc order by TenLoaiT";
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            DataSet ds = new DataSet();
            da.Fill(ds, "LoaiThuoc");
            cmbLoaithuoc.DataSource = ds.Tables["LoaiThuoc"];
            cmbLoaithuoc.DisplayMember = "TenLoaiT";
            cmbLoaithuoc.ValueMember = "MaLoaiT";
        }

        public void LamMoi()
        {
            txtMathuoc.Text = "";
            txtMathuoc.Enabled = true;
            txtTenthuoc.Text = "";
            txtNhasx.Text = "";
            nbDongia.Value = 0;
            dtpNgaysx.Text = DateTime.Now.ToString();

            btnThem.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
        }

        private void dgvThuoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            if (row >= 0)
            {
                txtMathuoc.Text = dgvThuoc.Rows[row].Cells["MaThuoc"].Value.ToString();
                txtTenthuoc.Text = dgvThuoc.Rows[row].Cells["TenThuoc"].Value.ToString();
                txtNhasx.Text = dgvThuoc.Rows[row].Cells["NhaSX"].Value.ToString();
                dtpNgaysx.Text = dgvThuoc.Rows[row].Cells["NgaySX"].Value.ToString();
                nbDongia.Value = decimal.Parse(dgvThuoc.Rows[row].Cells["DonGia"].Value.ToString());
                cmbDonvi.SelectedItem = dgvThuoc.Rows[row].Cells["DonVi"].Value.ToString();
                cmbLoaithuoc.SelectedValue = dgvThuoc.Rows[row].Cells["MaLoaiT"].Value.ToString();

                txtMathuoc.Enabled = false;
                btnThem.Enabled = false;
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
            }
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=HP\DUONGNGUYEN;Initial Catalog=BanThuoc;Integrated Security=True");
            string query = "select * from Thuoc where MaLoaiT in (select MaLoaiT from LoaiThuoc where MaLoaiT like '%'+N'" + txtTimkiem.Text + "'+'%' or TenLoaiT like '%'+N'" + txtTimkiem.Text + "'+'%')";
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            DataSet ds = new DataSet();
            da.Fill(ds, "Thuoc");
            dgvThuoc.DataSource = ds.Tables["Thuoc"];
        }

        private void btnLammoi_Click(object sender, EventArgs e)
        {
            LamMoi();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=HP\DUONGNGUYEN;Initial Catalog=BanThuoc;Integrated Security=True");
            string queryCheck = "select count(*) from Thuoc where MaThuoc='" + txtMathuoc.Text + "'";
            conn.Open();
            SqlCommand cmdCheck = new SqlCommand(queryCheck, conn);
            int soluong = (int)cmdCheck.ExecuteScalar();
            conn.Close();

            if (soluong >= 1)
            {
                MessageBox.Show("Bản ghi đã tồn tại!", "Thông báo");
                //LamMoi();
            }
            else
            {
                conn.Open();
                string query = "insert into Thuoc(MaThuoc, TenThuoc, NhaSX, NgaySX, DonGia, DonVi, MaLoaiT) values('" + txtMathuoc.Text + "',N'" + txtTenthuoc.Text + "',N'" + txtNhasx.Text + "','" + dtpNgaysx.Value.Date + "','" + (int)nbDongia.Value + "',N'" + cmbDonvi.SelectedItem.ToString() + "','" + cmbLoaithuoc.SelectedValue.ToString() + "')";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Thêm dữ liệu thành công!", "Thông báo");
                getData();
                LamMoi();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=HP\DUONGNGUYEN;Initial Catalog=BanThuoc;Integrated Security=True");
            conn.Open();
            string query = "update Thuoc set TenThuoc=N'" + txtTenthuoc.Text + "', NhaSX=N'" + txtNhasx.Text + "', NgaySX='" + dtpNgaysx.Value.Date + "', DonGia='" + (int)nbDongia.Value + "', DonVi=N'" + cmbDonvi.SelectedItem.ToString() + "', MaLoaiT='" + cmbLoaithuoc.SelectedValue.ToString() + "' where MaThuoc='" + txtMathuoc.Text + "'";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Sửa dữ liệu thành công!", "Thông báo");
            getData();
            LamMoi();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                SqlConnection conn = new SqlConnection(@"Data Source=HP\DUONGNGUYEN;Initial Catalog=BanThuoc;Integrated Security=True");
                conn.Open();
                string query = "delete from Thuoc where MaThuoc='" + txtMathuoc.Text + "'";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Xóa dữ liệu thành công!", "Thông báo");
                getData();
                LamMoi();
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
