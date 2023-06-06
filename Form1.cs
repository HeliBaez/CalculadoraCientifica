using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora_Cientifica
{
    public partial class Form1 : Form
    {
        public void ponerCero(object sender, EventArgs e)
        {
            var boton = ((Button) sender);
            if (textResultado.Text == "0")
                textResultado.Text = "";
            textResultado.Text += boton.Text;
        }
        double numero1; //Las variables globales
        double numero2;
        char operador;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //Pantalla
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {
            // Numero 1
        }

        private void button7_Click(object sender, EventArgs e)
        {
            // Numero 8
            var buton = ((Button) sender);  
        }

        private void button20_Click(object sender, EventArgs e)
        {
            //Punto .
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Porciento
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //C
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Elevado a 2
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Delete
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //Numero 7
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //Numero 9
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //Por *
        }

        private void button12_Click(object sender, EventArgs e)
        {
            //Numero 4
        }

        private void button11_Click(object sender, EventArgs e)
        {
            //Numero 5
        }

        private void button10_Click(object sender, EventArgs e)
        {
            //Numero 6
        }

        private void button9_Click(object sender, EventArgs e)
        {
            //Resta -
        }

        private void button15_Click(object sender, EventArgs e)
        {
            //Numero 2
        }

        private void button14_Click(object sender, EventArgs e)
        {
            //Numero 3
        }
         private  void ClickOperador(object sender, EventArgs e)
        {
            var boton = ((Button)sender);
            numero1 = Convert.ToDouble(textResultado.Text);
            if (operador =='²' )
            {
                numero1 = Math.Pow(numero1, 2);
                textResultado.Text = numero1.ToString();

            }
          else if (operador == '√')
            {
                numero1 = Math.Sqrt(numero1);
                textResultado.Text = numero1.ToString();

            }
            operador = Convert.ToChar(boton.Tag);
            textResultado.Text = "0";
        }
        private void button13_Click(object sender, EventArgs e)
        {
               //Signo De +

            //operador = '+';
            //aux1 = double.Parse(textBox1.Text);
            //textBox1.Clear();

        }

        private void button19_Click(object sender, EventArgs e)
        {
            // Numero 0
        }

        private void button17_Click(object sender, EventArgs e)
        {
            numero2 = Convert.ToDouble(textResultado.Text);
            if (operador  == '+')
            {
                textResultado.Text = (numero1 + numero2).ToString();
                numero1 = Convert.ToDouble(textResultado.Text);
            }
            else if (operador == '-')
            {
                textResultado.Text = (numero1 - numero2).ToString();
                numero1 = Convert.ToDouble(textResultado.Text);
            }
            else if (operador == '*')
            {
                textResultado.Text = (numero1 *  numero2).ToString();
                numero1 = Convert.ToDouble(textResultado.Text);
            }
            else if (operador == '/')
            {
                textResultado.Text = (numero1 / numero2).ToString();
                numero1 = Convert.ToDouble(textResultado.Text);
            }

        }

        private void RAIZ_Click(object sender, EventArgs e)
        {
            //raiz
        }

        private void DIVICION_Click(object sender, EventArgs e)
        {
            //Divicion
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            //Cambiar operacion
        }

        private void CE_Click(object sender, EventArgs e)
        {

        }
    }
}
