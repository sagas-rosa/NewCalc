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
        string entrada = "";
        Calculadora calc = new Calculadora();
        bool esperandoSegundoValor = false;
        public Form1()
        {
            InitializeComponent();
            this.KeyPreview = true;
            //this.KeyDown = true;

        }

        private void button1_Click(object sender, EventArgs e)
        {
           /* int r = random.Next(0, 256);
            int g = random.Next(0, 256);
            int b = random.Next(0, 256);

            this.BackColor = Color.FromArgb(r, g, b);*/
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button18_Click(object sender, EventArgs e)
        {

        }

        private void btn_Numero_click (object sender, EventArgs e)
        {
            Button b = (Button)sender;
            entrada += b.Text;
            textBox1.Text = entrada;
        }

        private void btn_Operaciones_Click(object sender, EventArgs e)
        {
            Button boton = (Button)sender;

            if (!string.IsNullOrEmpty(entrada))
            {
                calc.Valor1 = Convert.ToDouble(entrada);
                calc.Operacion = boton.Text;
                entrada = "";
                esperandoSegundoValor = true;
                textBox1.Text = "";
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && entrada != "")
            {
                calc.Valor2 = Convert.ToDouble(entrada);
                try
                {
                    double resultado = calc.Calcular();
                    textBox1.Text = resultado.ToString();
                    entrada = resultado.ToString(); // Para seguir usando el resultado
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    entrada = "";
                    textBox1.Text = "";
                }
                e.SuppressKeyPress = true;
            }
        }

        private void btn_Punto(object sender, EventArgs e)
        {

        }

        private void btn_Borrar(object sender, EventArgs e)
        {
            entrada = "";
            textBox1.Text = "";
            calc = new Calculadora();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (entrada.Length > 0)
            {
                entrada = entrada.Substring(0, entrada.Length - 1);
               textBox1.Text = entrada;
            }
        }

        private void btn_Numero_Click(object sender, EventArgs e)
        {
            Button boton = (Button)sender;
            entrada += boton.Text;
            textBox1.Text = entrada;
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (entrada.StartsWith("-"))
            {
                entrada = entrada.Substring(1); // Quita el signo negativo
            }
            else if (entrada != "")
            {
                entrada = "-" + entrada; // Agrega el signo negativo
            }

            textBox1.Text = entrada;
        }
    }
}
