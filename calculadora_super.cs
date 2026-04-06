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
        double PriNumero;
        string Operacao;
        bool Limpar;
        bool ResultadoExibido = false;
        double SecNumero;
        public calculadora_super()
        {
            InitializeComponent();
        }

        private void f_digitos(object sender, EventArgs e)
        {
            string digito = ((Button)sender).Text;

            if (lbl_visor.Text == "0" || Limpar == true || ResultadoExibido == true)
            {
                lbl_visor.Text = digito;
                Limpar = false;
                ResultadoExibido = false; 
            }
            else
            {
                lbl_visor.Text += digito;
            }
            this.ActiveControl = null;
        }

        private void f_operacoes(object sender, EventArgs e)
        {
            PriNumero = double.Parse(lbl_visor.Text);
            Operacao = ((Button)sender).Text;
            Limpar = true;
            ResultadoExibido = false;

            
            if (Operacao == "²√x")
            {
                lbl_visor2.Text = "√" + PriNumero;
            }
            else if (Operacao == "x²")
            {
                lbl_visor2.Text = PriNumero + "^";
            }
            else
            {
                lbl_visor2.Text = PriNumero + " " + Operacao + " ";
            }

            lbl_visor.Focus();
        }

        private void btn_igual_Click(object sender, EventArgs e)
        {
            if (ResultadoExibido || string.IsNullOrEmpty(Operacao)) return;

            SecNumero = double.Parse(lbl_visor.Text);
            double resultado = 0;

            switch (Operacao)
            {
                case "+":
                    resultado = PriNumero + SecNumero;
                    break;
                case "--":
                    resultado = PriNumero - SecNumero;
                    break;
                case "/":
                    if (SecNumero == 0)
                    {
                        MessageBox.Show("Não é possível dividir um número por 0", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        btn_apagar_Click(null, null);
                        return;
                    }
                    resultado = PriNumero / SecNumero;
                    break;
                case "X":
                    resultado = PriNumero * SecNumero;
                    break;
                case "%":
                    resultado = (PriNumero / 100) * SecNumero;
                    break;
                case "x²":
                    resultado = Math.Pow(PriNumero, SecNumero); 
                    break;
                case "²√x":
                    if (PriNumero < 0)
                    {
                        MessageBox.Show("Não é possível calcular raiz quadrada de um número negativo", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        btn_apagar_Click(null, null);
                        return;
                    }
                    resultado = Math.Sqrt(PriNumero);
                    break;
            }

           
            if (Operacao == "x²")
                lbl_visor2.Text = PriNumero + "^" + SecNumero + " =";
            else if (Operacao == "²√x")
                lbl_visor2.Text = "√" + PriNumero + " =";
            else
                lbl_visor2.Text = PriNumero + " " + Operacao + " " + SecNumero + " =";

            lbl_visor.Text = resultado.ToString();
            ResultadoExibido = true;
            Operacao = "";
        }

        private void btn_apagar_Click(object sender, EventArgs e)
        {
            PriNumero = 0;
            Operacao = "";
            ResultadoExibido = false;
            lbl_visor.Text = "0";
            lbl_visor2.Text = "";
        }

        private void btn_virgula_Click(object sender, EventArgs e)
        {
            if (ResultadoExibido) return; 

            if (!lbl_visor.Text.Contains(","))
            {
                lbl_visor.Text += ",";
            }
        }

        private void btn_backspace_Click(object sender, EventArgs e)
        {
            if (ResultadoExibido) return;

            if (lbl_visor.Text.Length > 1)
                lbl_visor.Text = lbl_visor.Text.Substring(0, lbl_visor.Text.Length - 1);
            else
                lbl_visor.Text = "0";
        }

        private void btn_inverte_Click(object sender, EventArgs e)
        {
            lbl_visor.Text = (double.Parse(lbl_visor.Text) * -1).ToString();
        }

      
        private void label1_Click(object sender, EventArgs e) { }

        private void calculadora_super_Load(object sender, EventArgs e) { }

        private void calculadora_super_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) Close();


            

            if (e.KeyCode >= Keys.NumPad0 && e.KeyCode <= Keys.NumPad9)
            {
                Button botao = new Button();
                botao.Text = e.KeyCode.ToString().Substring(6);
                f_digitos(botao, e);
            }
            if (e.KeyCode >= Keys.D0 && e.KeyCode <= Keys.D9)
            {
                Button botao = new Button();
                botao.Text = e.KeyCode.ToString().Substring(1);
                f_digitos(botao, e);
            }
        }
    }
}