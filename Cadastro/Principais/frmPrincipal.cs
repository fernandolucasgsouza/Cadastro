using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cadastro
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLblData.Text = DateTime.Now.ToShortDateString();
            toolStripStatusLblHora.Text = DateTime.Now.ToShortTimeString();
        }

        private void TelaPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void sairToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void sairToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void calculadoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("calc");
        }

        private void excelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("excel");
        }

        private void wordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("winword");
        }

        private void tsMenuItemNovoContato_Click(object sender, EventArgs e)
        {
            frmCadContato telaCadContatos = new frmCadContato();
            telaCadContatos.ShowDialog();
        }

        private void tsMenuItemNovoUsuario_Click(object sender, EventArgs e)
        {
            frmCadUsuario telaCadUsuarios = new frmCadUsuario();
            telaCadUsuarios.ShowDialog();
        }

        private void tsMenuItemNovoGrupo_Click(object sender, EventArgs e)
        {
            frmCadGrupo telaCadGrupos = new frmCadGrupo();
            telaCadGrupos.ShowDialog();
        }

        private void telefoneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadTelefone telaCadTelefones = new frmCadTelefone();
            telaCadTelefones.ShowDialog();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            frmListContato lista = new frmListContato();
            lista.ShowDialog();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Essa função está em processo de desenvolvimento\n Obrigado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Essa função está em processo de desenvolvimento\n Obrigado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Essa função está em processo de desenvolvimento\n Obrigado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void gruposToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Essa função está em processo de desenvolvimento\n Obrigado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void usuáriosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Essa função está em processo de desenvolvimento\n Obrigado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void sobreToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Essa função está em processo de desenvolvimento\n Obrigado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
}
