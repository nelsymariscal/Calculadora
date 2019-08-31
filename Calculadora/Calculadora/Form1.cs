using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        double n1, n2, re;
        string op;
        public Form1()
        {
            InitializeComponent();
        }
        private void Button18_Click(object sender, EventArgs e)
        {
            op = "/";
            n1 = double.Parse(pantalla.Text);
            pantalla.Clear();
        }
        private void Button13_Click(object sender, EventArgs e)
        {
            if (pantalla.Text.Length==1)
            {
                pantalla.Text = "";
            }
            else
            {
                pantalla.Text = pantalla.Text.Substring(0, pantalla.Text.Length - 1);
            }
        }
        private void Punto_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + ".";
        }
        private void Cero_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "0";
        }
        private void Uno_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "1";

        }
        private void Dos_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "2";

        }
        private void Tres_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "3";

        }
        private void Cuatro_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "4";

        }
        private void Cinco_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "5";

        }
        private void Seis_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "6";

        }
        private void Siete_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "7";
        }

        private void Ocho_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "8";
        }
        private void Menos_Click(object sender, EventArgs e)
        {
            op = "-";
            n1 = double.Parse(pantalla.Text);
            pantalla.Clear();
        }
        private void Multiplicacion_Click(object sender, EventArgs e)
        {
            op = "*";
            n1 = double.Parse(pantalla.Text);
            pantalla.Clear();
        }
        private void Porcentaje_Click(object sender, EventArgs e)
        {
            op = "%";
            n1 = double.Parse(pantalla.Text);
            pantalla.Clear();
        }

        private void Igual_Click(object sender, EventArgs e)
        {
            n2 = double.Parse(pantalla.Text);
            if(op=="+")
            {
                re = n1 + n2;
                pantalla.Text = re.ToString();
            }
            else if (op == "-")
            {
                re = n1 - n2;
                pantalla.Text = re.ToString();
            }
            else if (op == "*")
            {
                re = n1 * n2;
                pantalla.Text = re.ToString();
            }
            else if (op == "/")
            {
                re = n1 / n2;
                pantalla.Text = re.ToString();

            }
            else if (op == "%")
            {
                re = n1 /100* n2;
                pantalla.Text = re.ToString();
            }
        }

        private void C_Click(object sender, EventArgs e)
        {
            pantalla.Clear();
        }

        private void Nueve_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "9";
        }

        private void Mas_Click(object sender, EventArgs e)
        {
            op = "+";
            n1 = double.Parse(pantalla.Text);
            pantalla.Clear();
        }
    }
}
