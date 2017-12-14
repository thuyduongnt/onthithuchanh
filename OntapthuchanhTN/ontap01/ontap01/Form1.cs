using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ontap01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        //so chinh phuong
        public bool Sochinhphuong(int scp)
        {
            Boolean kq = false;

            double x = Math.Sqrt(scp);

            if ((int)x * x == scp) { kq = true; }

            return kq;

        }
        //so nguyen to
        public bool Check(int x)
        {
            int count = 0;
            for (int j = 1; j <= x; j++)
            {
                if (x % j == 0)
                {
                    count++;
                }
            }
            if (count == 2)
            {
                return true;
            }
            else
            {
                return false;
            }
                
        }
        private void check_btn_Click(object sender, EventArgs e)
        {
            var n = Convert.ToInt32(text_nhap.Text);
            string ketqua = " ";
            for (int i = 0; i <= n; i++)
            {
                if (Sochinhphuong(i))
                {
                    ketqua += i + ", ";
                }
            }
            text_xuat.Text = ketqua;
        }

            /*var n = Convert.ToInt32(text_nhap.Text);
            string ketqua =" ";
            for (int i = 0; i <= n; i++)
            {
                if (Check(i))
                {
                    ketqua += i + ", ";
                }
            }
            text_xuat.Text = ketqua;
        }*/
    }
}
