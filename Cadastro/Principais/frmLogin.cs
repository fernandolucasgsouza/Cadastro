using Cadastro.DAO;
using Cadastro.Entidades;
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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {

            LoginDAO dao = new LoginDAO();

            bool resultado = dao.verificaLogin(textLogin.Text, textSenha.Text);

            if (resultado != false)
            {
                frmPrincipal telaPrincipal = new frmPrincipal();
                telaPrincipal.Show();

                this.Close();
            }
            else
            {
                MessageBox.Show("Usuário ou Senha Inválidos", "Ocorreu um ERRO ao autenticar", MessageBoxButtons.OK, MessageBoxIcon.Error);

                textLogin.Clear();
                textSenha.Clear();
            }

        }    

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
