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
    public partial class frmRadio : Form
    {
        public frmRadio()
        {
            InitializeComponent();
        }

        private void rb_som_CheckedChanged(object sender, EventArgs e)
        {

            lbl_sinal.Text = "+";

        }

        private void btn_cal_Click(object sender, EventArgs e)
        {
            try
            {
                if (rb_som.Checked)
                {
                    double a = double.Parse(txt_pri.Text);
                    double b = double.Parse(txt_sec.Text);
                    lbl_resp.Text = (a + b).ToString();
                }
                if (rb_sub.Checked)
                {
                    double a = double.Parse(txt_pri.Text);
                    double b = double.Parse(txt_sec.Text);
                    lbl_resp.Text = (a - b).ToString();
                }
                if (rb_mult.Checked)
                {
                    double a = double.Parse(txt_pri.Text);
                    double b = double.Parse(txt_sec.Text);
                    lbl_resp.Text = (a * b).ToString();
                }
                if (rb_div.Checked)
                {
                    double a = double.Parse(txt_pri.Text);
                    double b = double.Parse(txt_sec.Text);
                    lbl_resp.Text = (a / b).ToString();
                    if (txt_sec.Text == "0")
                    {
                        MessageBox.Show("Não é possível dividir um número por 0", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        lbl_sinal.Text = "?";
                        lbl_resp.Text = "?";
                        txt_pri.Clear();
                        txt_sec.Clear();
                    }
                }
                if (rb_pot.Checked)
                {
                    double a = double.Parse(txt_pri.Text);
                    double b = double.Parse(txt_sec.Text);
                    double res = Math.Pow(a, b);
                    lbl_resp.Text = (res).ToString();
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Informe apenas números");
            }
        }

        private void rb_sub_CheckedChanged(object sender, EventArgs e)
        {
            lbl_sinal.Text = "-";
        }

        private void rb_div_CheckedChanged(object sender, EventArgs e)
        {
            lbl_sinal.Text = "/";
        }

        private void rb_mult_CheckedChanged(object sender, EventArgs e)
        {
            lbl_sinal.Text = "X";
        }

        private void rb_pot_CheckedChanged(object sender, EventArgs e)
        {
            lbl_sinal.Text = "^";
        }

        private void btn_limp_Click(object sender, EventArgs e)
        {
            lbl_sinal.Text = "?";
            lbl_resp.Text = "?";
            txt_pri.Clear();
            txt_sec.Clear();
        }

        private void btn_fec_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmRadio_Load(object sender, EventArgs e)
        {

        }
    }
}
