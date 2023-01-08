using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Faktoriyel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            int toplam = 0, carpim = 1, x;
            x = Convert.ToInt32(textBox1.Text);
            if (x % 2 == 0) //Girilen sayı çiftse
            {
                for (int i = 1; i <= x; i++)
                {
                    toplam += i;
                }
                label1.ForeColor = Color.Blue;
                label1.Text = "1 den " + x + " e kadar sayıların toplamı : " + toplam;
            }
            else //Girilen sayı Tekse
            {
                for (int i = 1; i <= x; i++)
                {
                    carpim *= i;
                }
                label1.ForeColor = Color.Red;
                label1.Text = "1 den " + x + " e kadar sayıların çarpımı : " + carpim;
            }
        }
    }
}
