using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalExamQuestion1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public bool checkHoanHao(int number)
        {
            bool check = false;
            int sum = 0;
            for (int i = 1; i < number; i++)
            {
                if (number % i == 0)
                {
                    sum = sum + i;
                }
            }
            if (sum == number)
            {
                check = true;
            }

            return check;
        }

        public bool checkAmstrong(int number)
        {
            bool check = false;
            int sum = 0;
            int dem = 0;
            int temp = number;

            //for (int i = number; number != 0; number = number / 10)
            //{
            //    t = number % 10;
            //    sum = sum + (t * t * t);
            //}
            //if (sum == number)
            //{
            //    check = true;
            //}

            //do
            //    dem++;
            //while (temp / 10);

            //do
            //    sum+=

            return check;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s = "";
            int so = int.Parse(textBox1.Text);
            /*
            for (int i = 1; i <= so; i++)
            {
                if (checkHoanHao(i))
                {
                    s = s + i + " ";
                }
            }
            label2.Text = "Các số hoàn hảo là: " + s;  
            */

            for (int i = 1; i <= so; i++)
            {
                if (checkAmstrong(i))
                {
                    s = s + i + " ";
                }
            }
            label2.Text = "Các số Amstrong là: " + s;
        }
    }
}
