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

namespace FinalExamOne
{
    public partial class CongViec : Form
    {
        public CongViec()
        {
            InitializeComponent();
        }


        private void CongViec_Load(object sender, EventArgs e)
        {
            getData();
            getCmbNV();
            getCmbLoaiCV();
            clearText();
        }

        public void getData()
        {
            //B1: Tạo kết nối csdl
            SqlConnection conn = new SqlConnection(@"Data Source=HP\DUONGNGUYEN;Initial Catalog=CongViec;Integrated Security=True");
            //B2: Khởi tạo truy vấn
            string query = "select * from CongViec order by MaLoaiCV asc";
            //B3: Thuc thi truy van
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            //B4: Khoi tao DataSet
            DataSet ds = new DataSet();
            //B5: Do du lieu len DataSet thong qua phuong thuc Fill()
            da.Fill(ds, "CongViec");
            //B6: Hien thi du lieu len dataGridView 
            dgvCongViec.DataSource = ds.Tables["CongViec"];

        }

        public void getCmbNV()
        {
            //B1: Tạo kết nối csdl
            SqlConnection conn = new SqlConnection(@"Data Source=HP\DUONGNGUYEN;Initial Catalog=CongViec;Integrated Security=True");
            //B2: Khởi tạo truy vấn
            string query = "select * from NhanVien";
            //B3: Thuc thi truy van
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            //B4: Khoi tao DataSet
            DataSet ds = new DataSet();
            //B5: Do du lieu len DataSet thong qua phuong thuc Fill()
            da.Fill(ds, "NhanVien");
            //B6: Hien thi du lieu len comboBox 
            cmbNV.DataSource = ds.Tables["NhanVien"];
            cmbNV.DisplayMember = "TenNV";
            cmbNV.ValueMember = "MaNV";
        }

        public void getCmbLoaiCV()
        {
            //B1: Tạo kết nối csdl
            SqlConnection conn = new SqlConnection(@"Data Source=HP\DUONGNGUYEN;Initial Catalog=CongViec;Integrated Security=True");
            //B2: Khởi tạo truy vấn
            string query = "select * from LoaiCV";
            //B3: Thuc thi truy van
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            //B4: Khoi tao DataSet
            DataSet ds = new DataSet();
            //B5: Do du lieu len DataSet thong qua phuong thuc Fill()
            da.Fill(ds, "LoaiCV");
            //B6: Hien thi du lieu len comboBox 
            cmbLoaiCV.DataSource = ds.Tables["LoaiCV"];
            cmbLoaiCV.DisplayMember = "TenLoaiCV";
            cmbLoaiCV.ValueMember = "LoaiCV";
        }

        private bool checkExist()
        {
            bool kt = false;
            string macv = txtMaCV.Text;
            SqlConnection conn = new SqlConnection(@"Data Source=HP\DUONGNGUYEN;Initial Catalog=CongViec;Integrated Security=True");
            conn.Open();
            string query = "select * from CongViec";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                if (macv == dr.GetString(0))
                {
                    kt = true;
                }
            }
            conn.Close();
            return kt;
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            //select * from CongViec where MaLoaiCV  in (select LoaiCV from LoaiCV where TenLoaiCV like '%' + N'ly' + '%' or MaLoaiCV like '%' + N'ly' + '%')
            //B1: Tạo kết nối csdl
            SqlConnection conn = new SqlConnection(@"Data Source=HP\DUONGNGUYEN;Initial Catalog=CongViec;Integrated Security=True");
            //B2: Khởi tạo truy vấn
            string query = "select * from CongViec where MaLoaiCV  in (select LoaiCV from LoaiCV where TenLoaiCV like '%' + N'" + txtTim.Text + "' + '%' or MaLoaiCV like '%' + N'" + txtTim.Text + "' + '%')";
            //B3: Thuc thi truy van
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            //B4: Khoi tao DataSet
            DataSet ds = new DataSet();
            //B5: Do du lieu len DataSet thong qua phuong thuc Fill()
            da.Fill(ds, "CongViec");
            //B6: Hien thi du lieu len dataGridView 
            dgvCongViec.DataSource = ds.Tables["CongViec"];

        }

        private void dgvCongViec_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            if (row >= 0)
            {
                txtMaCV.Text = dgvCongViec.Rows[row].Cells["MaCV"].Value.ToString();
                txtTenCV.Text = dgvCongViec.Rows[row].Cells["TenCV"].Value.ToString();
                cmbNV.SelectedValue = dgvCongViec.Rows[row].Cells["MaNV"].Value.ToString();
                txtBatDau.Text = dgvCongViec.Rows[row].Cells["BatDau"].Value.ToString();
                txtKetThuc.Text = dgvCongViec.Rows[row].Cells["KetThuc"].Value.ToString();
                cmbLoaiCV.SelectedValue = dgvCongViec.Rows[row].Cells["MaLoaiCV"].Value.ToString();

                txtMaCV.Enabled = false;
                btnThem.Enabled = false;
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
            }
        }

        public void clearText()
        {
            txtMaCV.Text = "";
            txtMaCV.Enabled = true;
            txtTenCV.Text = "";
            cmbNV.Enabled = true;
            txtBatDau.Text = "";
            txtKetThuc.Text = "";
            cmbLoaiCV.Enabled = true;

            btnThem.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            clearText();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (checkExist())
            {
                MessageBox.Show("Công việc đã tồn tại!", "Thông báo");
            }
            else
            {
                //B1: Khoi tao ket noi
                SqlConnection conn = new SqlConnection(@"Data Source=HP\DUONGNGUYEN;Initial Catalog=CongViec;Integrated Security=True");
                //B2: Mo ket noi
                conn.Open();
                //B3: Khoi tao truy van
                string query = "insert into CongViec(MaCV,TenCV,MaNV,BatDau,KetThuc,MaLoaiCV) values(N'" + txtMaCV.Text + "',N'" + txtTenCV.Text + "',N'" + cmbNV.SelectedValue.ToString() + "','" + txtBatDau.Text + "','" + txtKetThuc.Text + "',N'" + cmbLoaiCV.SelectedValue.ToString() + "')";
                SqlCommand cmd = new SqlCommand(query, conn);
                //B4: Thuc thi truy van
                cmd.ExecuteNonQuery();
                //B5: Dong ket noi
                conn.Close();
                //B6: Load lai du lieu
                MessageBox.Show("Thêm mới dữ liệu thành công!", "Thông báo");
                getData();
                clearText();
            }
            
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            //B1: Khoi tao ket noi
            SqlConnection conn = new SqlConnection(@"Data Source=HP\DUONGNGUYEN;Initial Catalog=CongViec;Integrated Security=True");
            //B2: Mo ket noi
            conn.Open();
            //B3: Khoi tao truy van
            string query = "Update CongViec set TenCV = N'" + txtTenCV.Text + "', MaNV = N'" + cmbNV.SelectedValue.ToString() + "', BatDau = '" + txtBatDau.Text + "', KetThuc = '" + txtKetThuc.Text + "', MaLoaiCV = '" + cmbLoaiCV.SelectedValue.ToString() + "' where MaCV = N'" + txtMaCV.Text + "'";
            SqlCommand cmd = new SqlCommand(query, conn);
            //B4: Thuc thi truy van
            cmd.ExecuteNonQuery();
            //B5: Dong ket noi
            conn.Close();
            //B6: Load lai du lieu
            MessageBox.Show("Sửa thành công!", "Thông báo");
            getData();
            clearText();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                //B1: Khoi tao ket noi
                SqlConnection conn = new SqlConnection(@"Data Source=HP\DUONGNGUYEN;Initial Catalog=CongViec;Integrated Security=True");
                //B2: Mo ket noi
                conn.Open();
                //B3: Khoi tao truy van
                string query = "delete from CongViec where MaCV=N'" + txtMaCV.Text + "'";
                SqlCommand cmd = new SqlCommand(query, conn);
                //B4: Thuc thi truy van
                cmd.ExecuteNonQuery();
                //B5: Dong ket noi
                conn.Close();
                //B6: Load lai du lieu
                MessageBox.Show("Xóa thành công!", "Thông báo");
                getData();
                clearText();
            }
            
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có thực sự muốn thoát?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                this.Close();
            }
        }

    }
}
