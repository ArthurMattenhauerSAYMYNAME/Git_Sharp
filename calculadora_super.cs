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
    public partial class calculadora_super : Form
    {
        decimal PriNumero;
        string Operacao;
        bool Limpar;
        public calculadora_super()
        {
            InitializeComponent();
        }
        private void f_digitos(object sender, EventArgs e) {
            string digito = ((Button)sender).Text;
            if(lbl_visor.Text == "0" || Limpar == true)
            {
                lbl_visor.Text = digito;
                Limpar = false;
            }
            else
            {
                lbl_visor.Text += digito;
            }

        }
        private void f_operacoes(object sender, EventArgs e)
        { 
            PriNumero = decimal.Parse(lbl_visor.Text);
            Operacao = ((Button)sender).Text;
            Limpar = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_apagar_Click(object sender, EventArgs e)
        {
            PriNumero = 0;
            lbl_visor.Text = "0";
        }

        private void btn_igual_Click(object sender, EventArgs e)
        {
            decimal SecNumero = decimal.Parse(lbl_visor.Text);
            switch(Operacao)
            {
                case "+":
                    lbl_visor.Text = (PriNumero + SecNumero).ToString();
                    break;
                case "-":
                    lbl_visor.Text = (PriNumero - SecNumero).ToString();
                    break;
                case "/":
                    lbl_visor.Text = (PriNumero  / SecNumero).ToString();
                    break;
                case "X":
                    lbl_visor.Text = (PriNumero *  SecNumero).ToString();
                    break;
            }
        }

        private void btn_virgula_Click(object sender, EventArgs e)
        {
            if (lbl_visor.Text.Contains(","))
            {

            }
            else
            {
                lbl_visor.Text += ",";
            }
        }

        private void btn_backspace_Click(object sender, EventArgs e)
        {
            lbl_visor.Text=lbl_visor.Text.Substring(0, lbl_visor.Text.Length - 1);
            if (lbl_visor.Text=="")
            {
                lbl_visor.Text = "0";
            }
        }
    }
}
