using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Git_Sharp.formularios
{
    public partial class MDI_menu : Form
    {
        public MDI_menu()
        {
            InitializeComponent();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {

        }

        private void comBotõesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Calculadora novoForm = new Calculadora();
            novoForm.MdiParent = this;
            novoForm.Show();
        }

        private void MDI_menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("Você deseja mesmo sair?", "Sair", 
            MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)==DialogResult.No)
            {
               e.Cancel = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbl_hora.Text = DateTime.Now.ToString();
        }

        private void comRadioButtonsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRadio novoForm = new frmRadio();
            novoForm.MdiParent = this;
            novoForm.Show();
        }
    }
}
