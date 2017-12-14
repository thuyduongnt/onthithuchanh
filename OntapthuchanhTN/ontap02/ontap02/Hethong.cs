using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ontap02
{
    public partial class Hethong : Form
    {
        public Hethong()
        {
            InitializeComponent();
        }

        private void hệThốngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 form2 = new Form1();
            form2.Show();
           // this.Close();
        }
    }
}
