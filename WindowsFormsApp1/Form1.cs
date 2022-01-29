using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        static string s = "Результаты \r\n";
        static string ans = "";
        public Form1()
        {
            InitializeComponent();
            this.textResult.AutoSize = false;
            this.textResult.Width = 300;
            this.textResult.Height = 200;
            textResult.Text = s;
            this.textResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            textResult.ReadOnly = true;
            anss.ReadOnly = true;
        }

   

        private void button1_Click(object sender, EventArgs e)
        {
            double x = double.Parse(textX.Text);
            double y = double.Parse(textY.Text);
            double z = double.Parse(textZ.Text);

            if(checkBox1.Checked == true)
            {
                x *= 2;
                y *= 2;
                z *= 2;
                textX.Text = x.ToString();
                textY.Text = y.ToString();
                textZ.Text = z.ToString();
            }
            s += "x=" + textX.Text + "\r\ny=" + textY.Text + "\r\nz=" + textZ.Text+"\r\n";
            textResult.Text = s;
            if (xym.Checked == true)
            {
                anss.Text = "ln(fx)+(fx^2+y)^3";
                double a = Math.Log((Math.Pow(x, 2) + Math.Pow((Math.Pow(x, 2) + y), 3)));
                s += "Ответ: " + a.ToString() + xym.Text + "\r\n";
            }
            else if (xyl.Checked == true)
            {
                anss.Text = "ln(|fx/y|)+(fx+y)^3";
                double a = Math.Log(Math.Abs(x * x / y)) + Math.Pow(x * x + y, 3);
                s += "Ответ: " + a.ToString() + "\r\n";
            }
            else if (xx.Checked == true)
            {
                anss.Text = "(fx^2+y)^3";
                double a = Math.Pow(Math.Pow(x * x, 2) + y, 3);
                s += "Ответ: " + a.ToString() + "\r\n";
            }
            else if (yy.Checked == true)
            {
                anss.Text = "0";
                s += "Ответ: " + 0 +"\r\n";
            }
            textResult.Text = s;
        }

        private void textX_TextChanged(object sender, EventArgs e)
        {

        }

        private void textResult_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
