using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace winejercicio1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(textBox1.Text) > Convert.ToInt32(textBox2.Text) && (Convert.ToInt32(textBox1.Text) > Convert.ToInt32(textBox3.Text)))
            {
                label7.Text = textBox1.Text;
                if (Convert.ToInt32(textBox2.Text) < Convert.ToInt32(textBox3.Text))
                label9.Text = textBox2.Text;
                /*{
                    label9.Text = textBox2.Text;
                }*/
                else
                { label9.Text = textBox3.Text; }
                //   label7.Text = textBox1.Text;
            }
            else if ((Convert.ToInt32(textBox2.Text) > Convert.ToInt32(textBox1.Text) && Convert.ToInt32(textBox2.Text) > Convert.ToInt32(textBox3.Text)))
            {
                label7.Text = textBox2.Text;

                if ((Convert.ToInt32(textBox1.Text) < Convert.ToInt32(textBox3.Text)))
                    label9.Text = textBox1.Text;

                else

                    label9.Text = textBox3.Text;
            }
            else
            {
                label7.Text = textBox3.Text;
                if ((Convert.ToInt32(textBox1.Text) < Convert.ToInt32(textBox2.Text)))
                    label9.Text = textBox1.Text;
                else
                {
                    label9.Text = textBox2.Text;
                }
            }
                //if (Convert.ToInt32(textBox2.Text) > Convert.ToInt32(textBox3.Text))

                Decimal newVariable = Convert.ToDecimal(textBox1.Text) + Convert.ToDecimal(textBox2.Text) + Convert.ToDecimal(textBox3.Text);
            label8.Text = newVariable.ToString();
        }
    }
}
