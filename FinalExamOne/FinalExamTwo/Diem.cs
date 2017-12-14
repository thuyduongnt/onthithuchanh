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

namespace FinalExamTwo
{
    public partial class Diem : Form
    {
        public Diem()
        {
            InitializeComponent();
        }

        private void Diem_Load(object sender, EventArgs e)
        {
            refresh();
            getData();
            getCmbSV();
            getCmbMH();
        }

        public void refresh()
        {
            cmbSV.Enabled = true;
            cmbMonhoc.Enabled = true;
            nbDiem.Value = 0;
            cmbNamhoc.Enabled = true;
            cmbNamhoc.Text = "";
            cmbKyhoc.Enabled = true;
            cmbKyhoc.Text = "";

            btnLammoi.Enabled = true;
            btnThem.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
        }

        public void getData()
        {
            //B1: Tao ket noi
            SqlConnection conn = new SqlConnection(@"Data Source=HP\DUONGNGUYEN;Initial Catalog=Banhang;Integrated Security=True");
            //B2: Tao truy van
            string query = "select * from Diem order by MaSV asc";
            //B3: Thuc thi truy van
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            //B4: Khoi tao DataSet
            DataSet ds = new DataSet();
            //B5: Do du lieu len DataSet thong qua phuong thuc Fill()
            da.Fill(ds, "Diem");
            //B6: Do du lieu len gridview
            dgvDiem.DataSource = ds.Tables["Diem"];
        }

        public void getCmbSV()
        {
            //B1: Tao ket noi
            SqlConnection conn = new SqlConnection(@"Data Source=HP\DUONGNGUYEN;Initial Catalog=Banhang;Integrated Security=True");
            //B2: Tao truy van
            string query = "select * from Sinhvien order by MaSV asc";
            //B3: Thuc thi truy van
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            //B4: Khoi tao DataSet
            DataSet ds = new DataSet();
            //B5: Do du lieu len DataSet thong qua phuong thuc Fill()
            da.Fill(ds, "Sinhvien");
            //B6: Do du lieu len combobox
            cmbSV.DataSource = ds.Tables["Sinhvien"];
            cmbSV.DisplayMember = "MaSV";
            cmbSV.ValueMember = "MaSV";
        }

        public void getCmbMH()
        {
            //B1: Tao ket noi
            SqlConnection conn = new SqlConnection(@"Data Source=HP\DUONGNGUYEN;Initial Catalog=Banhang;Integrated Security=True");
            //B2: Tao truy van
            string query = "select * from Monhoc order by TenMH asc";
            //B3: Thuc thi truy van
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            //B4: Khoi tao DataSet
            DataSet ds = new DataSet();
            //B5: Do du lieu len DataSet thong qua phuong thuc Fill()
            da.Fill(ds, "Monhoc");
            //B6: Do du lieu len combobox
            cmbMonhoc.DataSource = ds.Tables["Monhoc"];
            cmbMonhoc.DisplayMember = "TenMH";
            cmbMonhoc.ValueMember = "MaMH";
        }

        private void dgvDiem_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            if (row >= 0)
            {
                cmbSV.SelectedValue = dgvDiem.Rows[row].Cells["MaSV"].Value.ToString();
                cmbMonhoc.SelectedValue = dgvDiem.Rows[row].Cells["MaMH"].Value.ToString();
                nbDiem.Value = decimal.Parse(dgvDiem.Rows[row].Cells["DiemTK"].Value.ToString());
                cmbNamhoc.Text = dgvDiem.Rows[row].Cells["Namhoc"].Value.ToString();
                cmbKyhoc.Text = dgvDiem.Rows[row].Cells["Ky"].Value.ToString();

                cmbSV.Enabled = false;
                cmbMonhoc.Enabled = false;
                cmbNamhoc.Enabled = false;
                cmbKyhoc.Enabled = false;

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
            //B1: Tao ket noi
            SqlConnection conn = new SqlConnection(@"Data Source=HP\DUONGNGUYEN;Initial Catalog=Banhang;Integrated Security=True");
            //B2: Mo ket noi
            conn.Open();
            string check = "select count(*) from Diem where MaSV='" + cmbSV.SelectedValue.ToString() + "' and MaMH='" + cmbMonhoc.SelectedValue.ToString() + "' and NamHoc='" + cmbNamhoc.Text + "' and Ky='" + cmbKyhoc.Text + "'";
            SqlCommand cmdCheck = new SqlCommand(check, conn);
            int soluong = (int)cmdCheck.ExecuteScalar();
            conn.Close();

            if (soluong >= 1)
            {
                MessageBox.Show("Bản ghi đã tồn tại!", "Thông báo");
            }
            else
            {
                conn.Open();
                string query = "insert into Diem(MaSV,MaMH,DiemTK,NamHoc,Ky) values('" + cmbSV.SelectedValue.ToString() + "','" + cmbMonhoc.SelectedValue.ToString() + "','" + nbDiem.Value + "','" + cmbNamhoc.Text + "','" + cmbKyhoc.Text + "')";
                SqlCommand cmd = new SqlCommand(query, conn);
                //B4: Thuc thi truy van
                cmd.ExecuteNonQuery();
                //B5: Dong ket noi
                conn.Close();
                //B6: Load lai du lieu
                MessageBox.Show("Thêm dữ liệu thành công!", "Thông báo");
                getData();
                refresh();
            }
            
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            //B1: Tao ket noi
            SqlConnection conn = new SqlConnection(@"Data Source=HP\DUONGNGUYEN;Initial Catalog=Banhang;Integrated Security=True");
            //B2: Mo ket noi
            conn.Open();
            //B3: Khoi tao truy van
            string query = "update Diem set DiemTK='" + nbDiem.Value + "' where MaSV='" + cmbSV.SelectedValue.ToString() + "' and MaMH='" + cmbMonhoc.SelectedValue.ToString() + "' and NamHoc='" + cmbNamhoc.Text + "' and Ky='" + cmbKyhoc.Text + "'";
            SqlCommand cmd = new SqlCommand(query, conn);
            //B4: Thuc thi truy van
            cmd.ExecuteNonQuery();
            //B5: Dong ket noi
            conn.Close();
            //B6: Load lai du lieu
            MessageBox.Show("Sửa dữ liệu thành công!", "Thông báo");
            getData();
            refresh();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                //B1: Tao ket noi
                SqlConnection conn = new SqlConnection(@"Data Source=HP\DUONGNGUYEN;Initial Catalog=Banhang;Integrated Security=True");
                //B2: Mo ket noi
                conn.Open();
                //B3: Khoi tao truy van
                string query = "delete from Diem where MaSV='" + cmbSV.SelectedValue.ToString() + "' and MaMH='" + cmbMonhoc.SelectedValue.ToString() + "' and NamHoc='" + cmbNamhoc.Text + "' and Ky='" + cmbKyhoc.Text + "'";
                SqlCommand cmd = new SqlCommand(query, conn);
                //B4: Thuc thi truy van
                cmd.ExecuteNonQuery();
                //B5: Dong ket noi
                conn.Close();
                //B6: Load lai du lieu
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

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            //B1: Tao ket noi
            SqlConnection conn = new SqlConnection(@"Data Source=HP\DUONGNGUYEN;Initial Catalog=Banhang;Integrated Security=True");
            //B2: Tao truy van
            string query = "select * from Diem where MaSV in (select MaSV from Sinhvien where MaLop in (select MaLop from Lop where MaLop like '%' + N'" + txtTimkiem.Text + "' + '%' or TenLop like '%' + N'" + txtTimkiem.Text + "' + '%'))";
            //B3: Thuc thi truy van
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            //B4: Khoi tao DataSet
            DataSet ds = new DataSet();
            //B5: Do du lieu len DataSet thong qua phuong thuc Fill()
            da.Fill(ds, "Diem");
            //B6: Do du lieu len gridview
            dgvDiem.DataSource = ds.Tables["Diem"];
        }

    }
}
