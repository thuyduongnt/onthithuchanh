using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace THTN
{
    public partial class Bai1 : Form
    {
        public Bai1()
        {
            InitializeComponent();
        }

        private void btnHienthi_Click(object sender, EventArgs e)
        {
            try
            {
                int n = int.Parse(txtN.Text);

                string s = "";
                for(int i=1; i<=n; i++)
                {

                    ////Hàng i có i dấu * và 1 dấu \n
                    //for(int j=1; j<=i; j++)
                    //{
                    //    s = s + "*";
                    //}
                    //s = s + "\n";

                    ////Hàng 
                    //for (int j = 1; j <= (n + 1 - i); j++)
                    //{
                    //    s = s + "*";
                    //}
                    //s = s + "\n";

                    ////Hang i co n-i dau ' ', i dau * va 1 dau \n
                    //for(int j=1; j<=(n-i); j++)
                    //{
                    //    s = s + " ";
                    //}
                    //for (int j = 1; j <= i; j++)
                    //{
                    //    s = s + "*";
                    //}
                    //s = s + "\n";


                    ////Tam giac nguoc căn phai
                    //for (int j = 1; j <= (i - 1); j++)
                    //{
                    //    s = s + " ";
                    //}
                    //for (int j = 1; j <= (n+1-i); j++)
                    //{
                    //    s = s + "*";
                    //}
                    //s = s + "\n";


                    ////Tam giac can
                    //for (int j = 1; j <= (n - i); j++)
                    //{
                    //    s = s + " ";
                    //}
                    //for (int j = 1; j <= (2*i-1); j++)
                    //{
                    //    s = s + "*";
                    //}
                    //s = s + "\n";

                    //
                    

                    
                    
                    s = s + "\n";
                }
                
                lbKQ.Text = s;
            }
            catch
            {
                MessageBox.Show("Dữ liệu nhập không đúng!");
            }
            
        }
    }
}
