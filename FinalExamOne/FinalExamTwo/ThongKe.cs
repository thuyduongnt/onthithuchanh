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
    public partial class ThongKe : Form
    {
        public ThongKe()
        {
            InitializeComponent();
        }

        private void ThongKe_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSet1.Diem' table. You can move, or remove it, as needed.
            
        }

        private void btnThongke_Click(object sender, EventArgs e)
        {
            this.DiemTableAdapter.Fill(this.DataSet1.Diem, txtMaSV.Text, int.Parse(cmbNamhoc.Text));

            this.reportViewer1.RefreshReport();
        }
    }
}
