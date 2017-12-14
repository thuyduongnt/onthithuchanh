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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_vehinh_Click(object sender, EventArgs e)
        {
            var x = Convert.ToInt32(text_hang.Text);
            //var y = Convert.ToInt32(text_cot.Text);
            string kq = "";
            for (int i = 0; i <x; i++)
            {
              for (int j = x; j > i; j--)
                {
                    kq = kq + "* ";
                    
                }
                kq = kq + "\n";
            }
            lblketqua.Text = kq;
        }

    }
}
