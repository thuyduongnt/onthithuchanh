using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalExamFive
{
    public partial class Bai1 : Form
    {
        public Bai1()
        {
            InitializeComponent();
        }

        private void btnVe_Click(object sender, EventArgs e)
        {
            try
            {

                //int n = int.Parse(txtSo.Text);
                //string s = "";

                /* for (int i = 1; i <= n; i++)
                 {
                 * //Hàng i có i dấu * và 1 dấu \n
                     for (int j = 1; j <= i; j++)
                     {
                         s += "*";
                     }
                     s += "\n";
                 }
                 lbketqua.Text = s;
                 */
                /*  for (int i = 1; i <= n; i++)
                  {
                 * //Hàng i có n+1-i dấu * và 1 dấu \n
                      for (int j = 1; j <= (n+1-i); j++)
                      {
                          s += "*";
                      }
                      s += "\n";
                  }
                  lbketqua.Text = s;
                  */
                /* for (int i = 1; i <= n; i++)
                 {
                     //Hàng i có n-i dấu cách, i dấu * và 1 dấu \n
                     for (int j = 1; j <= (n - i); j++)
                     {
                         s += " ";
                     }
                     for (int j = 1; j <= i; j++)
                     {
                         s += "*";
                     }
                     s += "\n";
                 }
                 lbketqua.Text = s;
                 */
                /*for (int i = 1; i <= n; i++)
                {
                    //Hàng i có i-1 dấu cách, n+1-i dấu * và 1 dấu \n
                    for (int j = 1; j <= (i-1); j++)
                    {
                        s += " ";
                    }
                    for (int j = 1; j <= (n+1-i); j++)
                    {
                        s += "*";
                    }
                    s += "\n";
                }
                lbketqua.Text = s;
                */
                /* for (int i = 1; i <= n; i++)
                 {
                     //Hàng i có n-1 dấu cách, 2i-1 dấu * và 1 dấu \n
                     for (int j = 1; j <= (n - 1); j++)
                     {
                         s += " ";
                     }
                     for (int j = 1; j <= (2*i-1); j++)
                     {
                         s += "*";
                     }
                     s += "\n";
                 }
                 lbketqua.Text = s;
                 */
                /*  for (int i = 1; i < n; i++)
                  {
                      //Hàng i có n-1 dấu cách, 2i-1 dấu * và 1 dấu \n
                      for (int j = 1; j <= (n - i); j++)
                      {
                          s += " ";
                      }
                      for (int j = 1; j <= (2 * i - 1); j++)
                      {
                          //chỉ hiển thị dấu * với 2 viền (vị trí 1 và vị trí 2*i-1)
                          if (j == 1 || j == (2 * i - 1))
                              s += "*";
                          else
                              s += " ";
                      }
                      s += "\n";
                  }
                  //xét riêng hàng lấy
                  for (int i = 1; i <=(2*n-1); i++)
                  {
                      s += "*";
                  }
                  lbketqua.Text = s;
                  */
                //tam giác trên
                /*  for(int i= 1; i<= 2*n-1;i++)
                  {
                      s += "*";
                  }
                  s += "\n";
                  for (int i = 2; i <= n; i++)
                  {
                      //Hàng i có n-1 dấu cách, 2i-1 dấu * và 1 dấu \n
                      for (int j = 1; j <= (i-1); j++)
                      {
                          s += " ";
                      }
                      for (int j = 1; j <= (2*n-2 * i + 1); j++)
                      {
                          //chỉ hiển thị dấu * với 2 viền (vị trí 1 và vị trí 2*i-1)
                          if (j == 1 || j == (2 * n - 2 * i + 1))
                              s += "*";
                          else
                              s += " ";
                      }
                      s += "\n";
                  }
                  lbketqua.Text = s;
                  //tam giacs dưới
                  for (int i = 2; i < n; i++)
                  {
                      //Hàng i có n-1 dấu cách, 2i-1 dấu * và 1 dấu \n
                      for (int j = 1; j <= (n - i); j++)
                      {
                          s += " ";
                      }
                      for (int j = 1; j <= (2 * i - 1); j++)
                      {
                          //chỉ hiển thị dấu * với 2 viền (vị trí 1 và vị trí 2*i-1)
                          if (j == 1 || j == (2 * i - 1))
                              s += "*";
                          else
                              s += " ";
                      }
                      s += "\n";
                  }
                  //xét riêng hàng lấy
                  for (int i = 1; i <= (2 * n - 1); i++)
                  {
                      s += "*";
                  }
                  lbketqua.Text = s;
                  */

                /*
                for (int i = 1; i <= n; i++)
                {
                    //Hàng i có n-1 dấu cách, 2i-1 dấu * và 1 dấu \n
                    for (int j = 1; j <= (i - 1); j++)
                    {
                        s += "0";
                    }
                    for (int j = 1; j <= (n + 1 - i); j++)
                    {
                        s += "*";
                    }
                    s += "\n";
                }
                for (int i = 2; i <= n; i++)
                {
                    //Hàng i có n-1 dấu cách, 2i-1 dấu * và 1 dấu \n
                    for (int j = 1; j <= n - 1; j++)
                    {
                        s += "0";
                    }
                    for (int j = 1; j <= i; j++)
                    {
                        s += "*";
                    }
                    s += "\n";
                }
                lbketqua.Text = s;
                 */

                int h = Int32.Parse(txtSo.Text);
                string s = "";
                //Tam giác trên
                for (int i = 1; i <= h; i++)
                {
                    //Hàng i có i-1 dấu cách, 2n-2i+1 dấu * và 1 dấu \n
                    for (int j = 1; j <= (i - 1); j++)
                    {
                        s += " ";
                    }
                    for (int j = 1; j <= (2 * h + 1 - 2 * i); j++)
                    {
                        //chỉ hiển thị dấu * với 2 viền (vị trí 1 và vị trí 2 * h + 1 - 2 * i)
                        if (i == 1 || j == 1 || j == (2 * h + 1 - 2 * i))
                            s += "*";
                        else
                            s += " ";
                    }
                    s += "\n";
                }
                //Tam giác dưới
                for (int i = 2; i <= h; i++)
                {
                    //Hàng i có i-1 dấu cách, 2n-2i+1 dấu * và 1 dấu \n
                    for (int j = 1; j <= (h - i); j++)
                    {
                        s += " ";
                    }
                    for (int j = 1; j <= (2 * i - 1); j++)
                    {
                        //chỉ hiển thị dấu * với 2 viền (vị trí 1 và vị trí 2 * i - 1)
                        if (i == h || j == 1 || j == (2 * i - 1))
                            s += "*";
                        else
                            s += " ";
                    }
                    s += "\n";
                }
                lbketqua.Text = s;
            }
            catch
            {
                MessageBox.Show("Dữ liệu nhập vào không đúng");
            }
        }
    }
}
