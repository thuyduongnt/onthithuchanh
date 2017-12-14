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
    public partial class CongViec : Form
    {
        public CongViec()
        {
            InitializeComponent();
        }

        private void CongViec_Load(object sender, EventArgs e)
        {
            Hienthi();
        }
        public void Hienthi()
        {
            KetnoiCSDL kn = new KetnoiCSDL();
            DataSet ds = new DataSet();
            ds = kn.TruyvanDL(CommandType.Text, "Select * from CongViec", null);
            dataGridView1.DataSource = ds.Tables[0];
        }
        public void Xoatrang()
        {
            txt_MaCV.Text = "";
            txt_TenCV.Text = "";
            txt_MaNV.Text = "";
            txt_Batdau.Text = "";
            txt_Ketthuc.Text = "";
            txt_MaloaiCV.Text = "";
        }
        private void btn_Them_Click(object sender, EventArgs e)
        {
            KetnoiCSDL kn = new KetnoiCSDL();
            bool kq = false;
            kq = kn.CapNhatDL(CommandType.Text, "Insert into CongViec(MaCV, TenCV, MaNV, BatDau, KetThuc, MaLoaiCV) values ('"+txt_MaCV.Text+"', '"+txt_TenCV.Text+"', '"+txt_MaNV.Text+"','"+txt_Batdau.Text+"', '"+txt_Ketthuc.Text+"','"+txt_MaloaiCV.Text+"')", null);
           // kq = kn.CapNhatDL(CommandType.Text, "Insert into CongViec(MaCV, TenCV, MaNV, BatDau, KetThuc, MaLoaiCV) values ('"+txt_MaCV.Text+"', '"+txt_TenCV.Text+"', '"+txt_MaNV.Text+"','"+txt_Batdau.Text+"', '"+txt_Ketthuc.Text+"', '"+txt_MaloaiCV.Text+"')", null);
            if (kq== true){
                MessageBox.Show("Thêm mới thành công");
                Hienthi();
                Xoatrang();
            }
            else
            {
                MessageBox.Show("Thêm mới thất bại");
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            KetnoiCSDL kn = new KetnoiCSDL();
            bool kq = false;
            kq = kn.CapNhatDL(CommandType.Text, "Delete from CongViec where MaCV = '" + txt_MaCV.Text + "' ", null);

            if (kq == true)
            {
                MessageBox.Show("Xóa thành công");
                Hienthi();
                Xoatrang();
            }
            else
            {
                MessageBox.Show("Xóa thất bại");
            }

        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            KetnoiCSDL kn = new KetnoiCSDL();
            bool kq = false;
            kq = kn.CapNhatDL(CommandType.Text, "Update CongViec set MaCV = '" + txt_MaCV.Text + "', TenCV = '" + txt_TenCV.Text + "', MaNV = '" + txt_MaNV.Text + "', BatDau = '" + txt_Batdau.Text + "', KetThuc = '" + txt_Ketthuc.Text + "', MaLoaiCV = '" + txt_MaloaiCV.Text + "' where MaCV = '"+txt_MaCV.Text+"' ", null);
            
            if (kq == true)
            {
                MessageBox.Show("Sửa thành công");
                Hienthi();
                Xoatrang();
            }
            else
            {
                MessageBox.Show("Sửa thất bại");
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            txt_MaCV.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txt_TenCV.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txt_MaNV.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txt_Batdau.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txt_Ketthuc.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txt_MaloaiCV.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
           
        }
    }
}
