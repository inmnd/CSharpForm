using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Label_a_Yazdirma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int top1, top2;
            bool a1 = int.TryParse(textBox1.Text, out top1);
            bool b1 = int.TryParse(textBox2.Text, out top2);
            if (top1 != 0 || top2 != 0)
            {
                int top = top1 + top2;
                textBox3.Text = Convert.ToString(top);
            }
            else
            {
                textBox3.Text = "0";
            }

            int cık1, cık2;
            bool a2 = int.TryParse(textBox6.Text, out cık1);
            bool b2 = int.TryParse(textBox5.Text, out cık2);
            if (cık1 != 0 || cık2 != 0l)
            {
                int cık = cık1 - cık2;
                textBox4.Text = Convert.ToString(cık);
            }
            else
            {
                textBox4.Text = "0";
            }

            int carp1, carp2;
            bool a3 = int.TryParse(textBox9.Text, out carp1);
            bool b3 = int.TryParse(textBox8.Text, out carp2);
            if (carp1 != 0 || carp2 != 0)
            {
                int carp = carp1 * carp2;
                textBox7.Text = Convert.ToString(carp);
            }
            else
            {
                textBox7.Text = "0";
            }

            int bol1, bol2;
            bool a4 = int.TryParse(textBox12.Text, out bol1);
            bool b4 = int.TryParse(textBox11.Text, out bol2);
            if (bol1 != 0 || bol2 != 0)
            {
                int bol = bol1 / bol2;
                textBox10.Text = Convert.ToString(bol);
            }
            else
            {
                textBox10.Text = "0";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            textBox9.Text = "";
            textBox10.Text = "";
            textBox11.Text = "";
            textBox12.Text = "";

        }
    }
}
