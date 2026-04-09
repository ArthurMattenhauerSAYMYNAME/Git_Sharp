using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Git_Sharp.formularios
{
    public partial class MDI_menu : Form
    {
        public MDI_menu()
        {
            this.WindowState = FormWindowState.Maximized;
            InitializeComponent();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {

        }

        private void comBotõesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Procura se já existe um formulário Calculadora aberto
            foreach (Form formAberto in this.MdiChildren)
            {
                if (formAberto is Calculadora)
                {
                    formAberto.Activate(); // Traz para frente
                    return; // Sai do método, não cria outro
                }
            }

            // Se não encontrou, cria um novo
            Calculadora novoForm = new Calculadora
            {
                MdiParent = this
            };
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
            foreach (Form formAberto in this.MdiChildren)
            {
                if (formAberto is frmRadio)
                {
                    formAberto.Activate();
                    return; 
                }
            }

            frmRadio novoForm = new frmRadio
            {
                MdiParent = this
            };
            novoForm.Show();
        }

        private void MDI_menu_Load(object sender, EventArgs e)
        {

        }

        private void cascataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void horizontalmenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void verticalmenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void novoToolStripButton_Click(object sender, EventArgs e)
        {
            Process.Start("notepad.exe");
        }

        private void visorÚnicoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Procura se já existe um formulário Calculadora aberto
            foreach (Form formAberto in this.MdiChildren)
            {
                if (formAberto is calculadora_super)
                {
                    formAberto.Activate(); // Traz para frente
                    return; // Sai do método, não cria outro
                }
            }

            // Se não encontrou, cria um novo
            calculadora_super novoForm = new calculadora_super
            {
                MdiParent = this
            };
            novoForm.Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
