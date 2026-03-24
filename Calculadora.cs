using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Git_Sharp
{
    public partial class Calculadora : Form
    {
        public Calculadora()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btn_somar_Click(object sender, EventArgs e)
        {
            lbl_sinal.Text = "+";
            try
            {
                double a = double.Parse(txt_1.Text);
                double b = double.Parse(txt_2.Text);
                lbl_resultado.Text = (a + b).ToString();
            }
            catch(FormatException)
            {
                MessageBox.Show("Informe apenas números");
            }
        }

        private void btn_sub_Click(object sender, EventArgs e)
        {
            lbl_sinal.Text = "-";
            try
            {
                double a = double.Parse(txt_1.Text);
                double b = double.Parse(txt_2.Text);
                lbl_resultado.Text = (a - b).ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Informe apenas números");
            }
        }

        private void btn_Mult_Click(object sender, EventArgs e)
        {
            lbl_sinal.Text = "X";
            try
            {
                double a = double.Parse(txt_1.Text);
                double b = double.Parse(txt_2.Text);
                lbl_resultado.Text = (a * b).ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Informe apenas números");
            }
        }

        private void btn_div_Click(object sender, EventArgs e)
        {
            lbl_sinal.Text = "/";
            try
            {
                double a = double.Parse(txt_1.Text);
                double b = double.Parse(txt_2.Text);
                lbl_resultado.Text = (a / b).ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Informe apenas números");
            }
            catch (DivideByZeroException)
            {
                MessageBox.Show("Impossível divisão por zero");
            }
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            lbl_sinal.Text = "?";
            lbl_resultado.Text = "?";
            txt_1.Clear();
            txt_2.Clear();
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_comp_Click(object sender, EventArgs e)
        {

            try
            {
                double a = double.Parse(txt_1.Text);
                double b = double.Parse(txt_2.Text);
                if(a > b)
                {
                    lbl_resultado.Text = a +  " > " + b;
                }
                else if (a < b)
                {
                    lbl_resultado.Text = a + " < " + b;
                }
                else
                {
                    lbl_resultado.Text = a + " = " + b;
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Informe apenas números");
            }
        }

        private void btn_Par_Click(object sender, EventArgs e)
        {
            try
            {
                double a = double.Parse(txt_1.Text);
                double b = double.Parse(txt_2.Text);
                if(a % 2 == 0 && b % 2 == 0)
                {
                    lbl_resultado.Text = a + " e " + b + " são pares";
                }
                else if (a % 2 != 0 && b % 2 != 0)
                {
                    lbl_resultado.Text = a + " e " + b + " são Impares";
                }
                else if (a % 2 != 0 && b %2 == 0)
                {
                    lbl_resultado.Text = a + " é impar e " + b + " é par";
                }
                else if (a % 2 == 0 && b %2 != 0)
                {
                    lbl_resultado.Text = a + " é par e " + b + " é impar";
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Informe apenas números");
            }
        }

        private void lbl_resultado_Click(object sender, EventArgs e)
        {

        }
    }
}
