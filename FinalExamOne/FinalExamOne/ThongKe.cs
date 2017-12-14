using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalExamOne
{
    public partial class ThongKe : Form
    {
        public ThongKe()
        {
            InitializeComponent();
        }

        private void FormThongKe_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSet1.view_Theodoi' table. You can move, or remove it, as needed.
            
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            this.view_TheodoiTableAdapter.Fill(this.DataSet1.view_Theodoi, (int)nbNam.Value);

            this.reportViewer1.RefreshReport();
        }
    }
}
