using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cau_1_Draw
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDraw_Click(object sender, EventArgs e)
        {
            lbDraw.ResetText();

            int cao = Int32.Parse(txtHeight.Text);
            string khoangtrang = "";

            for(int i=1; i<=cao; i++)
            {
                for(int j=0; j<cao-i; j++)
                {
                    lbDraw.Text += "   ";
                }
                for(int j=0; j<i; j++)
                {
                    lbDraw.Text += "*    ";
                }
                lbDraw.Text += "\n";
            }
        }
    }
}
