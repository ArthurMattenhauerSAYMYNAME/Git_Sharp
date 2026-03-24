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
        public calculadora_super()
        {
            InitializeComponent();
        }
        private void f_digitos(object sender, EventArgs e) {
            string digito = ((Button)sender).Text;
            if (lbl_visor.Text == "0")
            {
                lbl_visor.Text = " ";
            }
           
                

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_apagar_Click(object sender, EventArgs e)
        {
            lbl_visor.Text = "0";
        }

        private void btn_subtracao_Click(object sender, EventArgs e)
        {

        }
    }
}
