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
    public partial class LoaiCongViec : Form
    {
        public LoaiCongViec()
        {
            InitializeComponent();
        }

        private void LoaiCongViec_Load(object sender, EventArgs e)
        {
            Hienthi();
        }
        public void Hienthi()
        {
            KetnoiCSDL kn = new KetnoiCSDL();
            DataSet ds = new DataSet();
            ds = kn.TruyvanDL(CommandType.Text, "Select * from LoaiCV", null);
            dataGridView1.DataSource = ds.Tables[0];


        }
    }
}
