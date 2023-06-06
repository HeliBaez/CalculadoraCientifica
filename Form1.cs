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
        double aux1; //Las variables globales
        double aux2;
        string operador;
        public Form1()
        {
            InitializeComponent();
        }
        Clases.claseSuma objSuma = new Clases.claseSuma(); //Instanciando clase
        Clases.ClaseResta objrestarr = new Clases.ClaseResta();
        Clases.claseMultiplicacion objmultipl = new Clases.claseMultiplicacion();
        Clases.claseDivicion objdivid = new Clases.claseDivicion();
        Clases.clasePorciento objpor = new Clases.clasePorciento();
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //Pantalla
        }

        private void Form1_Load(object sender, EventArgs e) //Carga
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {
            // Numero 1
            textBox1.Text = textBox1.Text + '1';
        }

        private void button7_Click(object sender, EventArgs e)
        {
            // Numero 8
            textBox1.Text = textBox1.Text + '8';
        }

        private void button20_Click(object sender, EventArgs e)
        {
            //Punto .
            textBox1.Text=".";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Porciento
            operador = "%";
            aux1 = double.Parse(textBox1.Text);
            textBox1.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //C
            textBox1.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Elevado a 2
            double expo = double.Parse(textBox1.Text);
            expo= Math.Pow(expo, 2);
            textBox1.Text = expo.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Delete
            textBox1.Clear();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //Numero 7
            textBox1.Text = textBox1.Text + '7';
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //Numero 9
            textBox1.Text = textBox1.Text + '9';
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //Por *
            operador = "*";
            aux1 = double.Parse(textBox1.Text);
            textBox1.Clear();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            //Numero 4
            textBox1.Text = textBox1.Text + '4';
        }

        private void button11_Click(object sender, EventArgs e)
        {
            //Numero 5
            textBox1.Text = textBox1.Text + '5';
        }

        private void button10_Click(object sender, EventArgs e)
        {
            //Numero 6
            textBox1.Text = textBox1.Text + '6';
        }

        private void button9_Click(object sender, EventArgs e)
        {
            //Resta -
            operador = "-";
            aux1 = double.Parse(textBox1.Text);
            textBox1.Clear();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            //Numero 2
            textBox1.Text = textBox1.Text + '2';
        }

        private void button14_Click(object sender, EventArgs e)
        {
            //Numero 3
            textBox1.Text = textBox1.Text + '3';
        }

        private void button13_Click(object sender, EventArgs e)
        {
            //Signo De +

            operador = "+";
            aux1 = double.Parse(textBox1.Text);
            textBox1.Clear();

        }

        private void button19_Click(object sender, EventArgs e)
        {
            // Numero 0
            textBox1.Text = textBox1.Text + '0';
        }

        private void button17_Click(object sender, EventArgs e)
        {
            // IGUAL =
            aux2 = double.Parse(textBox1.Text);
            double operacionSuma,operacionrestar,operacionmutipli,operaconDivide,operacionprog ;
            switch (operador)
            {
                case "+":
                    operacionSuma = objSuma.sumas(aux1,aux2);
                    textBox1.Text = operacionSuma.ToString(); 
                    break;
                case "-":
                    operacionrestar = objrestarr.restas(aux1, aux2);
                    textBox1.Text = operacionrestar.ToString();
                    break;
                case "*":
                    operacionmutipli = objmultipl.multi(aux1, aux2);
                    textBox1.Text = operacionmutipli.ToString();
                    break;
                case "/":
                    operaconDivide = objdivid.Diviv(aux1, aux2);
                    textBox1.Text = operaconDivide.ToString();
                    break;
                case "%":
                    operacionprog = objpor.Modolo(aux1, aux2);
                    textBox1.Text = operacionprog.ToString();
                    break;
            }
        }

        private void RAIZ_Click(object sender, EventArgs e)
        {
            //raiz
            double raiz = double.Parse(textBox1.Text);
            raiz =Math.Sqrt(raiz);
            textBox1.Text = raiz.ToString();
        }

        private void DIVICION_Click(object sender, EventArgs e)
        {
            //Divicion
            operador = "/";
            aux1 = double.Parse(textBox1.Text);
            textBox1.Clear();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            //Potencia
            double expo = double .Parse(textBox1.Text);
            expo= Math.Pow(expo,2);
            textBox1 .Text = expo.ToString();
        }

        private void CE_Click(object sender, EventArgs e)
        {
            //cambiar valor
            double n = double.Parse(textBox1.Text);
            n = ((n) * (-1));
            textBox1.Text=n.ToString();

        }
    }
}
