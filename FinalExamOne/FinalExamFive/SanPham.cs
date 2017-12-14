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

namespace FinalExamFive
{
    public partial class SanPham : Form
    {
        public SanPham()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection(@"Data Source=HP\DUONGNGUYEN;Initial Catalog=Banhang5;Integrated Security=True");

        private void SanPham_Load(object sender, EventArgs e)
        {
            getData();
            getCmbLoaiSp();
            LamMoi();
        }

        public void getData()
        {
            string query = "select * from SanPham order by MaSP";
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            DataSet ds = new DataSet();
            da.Fill(ds, "SanPham");
            dgvSanpham.DataSource = ds.Tables["SanPham"];
        }

        public void getCmbLoaiSp()
        {
            string query = "select * from LoaiSanPham order by TenLoaiSP";
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            DataSet ds = new DataSet();
            da.Fill(ds, "LoaiSanPham");
            cmbLoaisp.DataSource = ds.Tables["LoaiSanPham"];
            cmbLoaisp.DisplayMember = "TenLoaiSP";
            cmbLoaisp.ValueMember = "MaLoaiSP";
        }

        public void LamMoi()
        {
            txtMasp.Text = "";
            txtMasp.Enabled = true;
            txtTensp.Text = "";
            nbDongia.Value = 1000;
            txtMotangan.Text = "";
            txtMotachitiet.Text = "";

            btnThem.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
        }

        private void dgvSanpham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            if (row >= 0)
            {
                txtMasp.Text = dgvSanpham.Rows[row].Cells["MaSP"].Value.ToString();
                txtTensp.Text = dgvSanpham.Rows[row].Cells["TenSP"].Value.ToString();
                nbDongia.Value = decimal.Parse(dgvSanpham.Rows[row].Cells["DonGia"].Value.ToString());
                txtMotangan.Text = dgvSanpham.Rows[row].Cells["MoTaNgan"].Value.ToString();
                txtMotachitiet.Text = dgvSanpham.Rows[row].Cells["MoTaChiTiet"].Value.ToString();
                cmbLoaisp.SelectedValue = dgvSanpham.Rows[row].Cells["MaLoaiSP"].Value.ToString();

                txtMasp.Enabled = false;
                btnThem.Enabled = false;
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
            }
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            string query = "select * from SanPham where MaLoaiSP in (select MaLoaiSP from LoaiSanPham where MaLoaiSP like '%' + '" + txtTimkiem.Text + "' + '%' or TenLoaiSP like '%' + N'" + txtTimkiem.Text + "' + '%')";
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            DataSet ds = new DataSet();
            da.Fill(ds, "SanPham");
            dgvSanpham.DataSource = ds.Tables["SanPham"];
        }

        private void btnLammoi_Click(object sender, EventArgs e)
        {
            LamMoi();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            conn.Open();
            string queryCheck = "select count(*) from SanPham where MaSP='" + txtMasp.Text + "'";
            SqlCommand cmdCheck = new SqlCommand(queryCheck, conn);
            int soluong = (int)cmdCheck.ExecuteScalar();
            conn.Close();

            if (soluong >= 1)
            {
                MessageBox.Show("Bản ghi đã tồn tại!", "Thông báo");
            }
            else
            {
                conn.Open();
                string query = "insert into SanPham(MaSP,TenSP,DonGia,MoTaNgan,MoTaChiTiet,MaLoaiSP) values('" + txtMasp.Text + "',N'" + txtTensp.Text + "','" + (int)nbDongia.Value + "',N'" + txtMotangan.Text + "',N'" + txtMotachitiet.Text + "','" + cmbLoaisp.SelectedValue.ToString() + "')";
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
            conn.Open();
            string query = "update SanPham set TenSP=N'" + txtTensp.Text + "', DonGia='" + (int)nbDongia.Value + "', MoTaNgan=N'" + txtMotangan.Text + "', MoTaChiTiet=N'" + txtMotachitiet.Text + "', MaLoaiSP='" + cmbLoaisp.SelectedValue.ToString() + "' where MaSP='" + txtMasp.Text + "'";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Sửa dữ liệu thành công!", "Thông báo");
            getData();
            LamMoi();
            
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                conn.Open();
                string query = "delete from SanPham where MaSP='" + txtMasp.Text + "'";
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
