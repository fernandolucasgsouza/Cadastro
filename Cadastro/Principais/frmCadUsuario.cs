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
    public partial class frmCadUsuario : Form
    {
        public frmCadUsuario()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void btnAdcionar_Click(object sender, EventArgs e)
        {
            UsuarioDAO daoUsuario = new UsuarioDAO();

            if (string.IsNullOrEmpty(textNomeUser.Text))
            {
                MessageBox.Show("O campo (Nome) não foi preenchido.\nVerifique o campo e insira os dados completos.",
                   "Erro de Inserção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (string.IsNullOrEmpty(textLoginUser.Text))
            {
                MessageBox.Show("O campo (Login) não foi preenchido.\nVerifique o campo e insira os dados completos.",
                   "Erro de Inserção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (string.IsNullOrEmpty(textSenhaUser.Text))
            {
                MessageBox.Show("O campo (Senha) não foi preenchido.\nVerifique o campo e insira os dados completos.",
                   "Erro de Inserção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (string.IsNullOrEmpty(textPerfilUser.Text))
            {
                MessageBox.Show("O campo (Perfil) não foi preenchido.\nVerifique o campo e insira os dados completos.",
                   "Erro de Inserção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (verifSituacao < 1)
            {
                MessageBox.Show("O ícone de (Situação) do usuário está imcompleto\nVerifique o campo e insira os dados completos.",
                    "Erro de Inserção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Usuario u = new Usuario() {
                    Nome = textNomeUser.Text,
                    Login = textLoginUser.Text,
                    Senha = textSenhaUser.Text,
                    Perfil = int.Parse(textPerfilUser.Text),
                    Ativo = situacao.ToString()
                };

                daoUsuario.Adiciona(u);
                
            }
        }

       
        public void LimpaCampoUsuario()
        {
            textNomeUser.Clear();
            textLoginUser.Clear();
            textSenhaUser.Clear();
            textPerfilUser.Clear();
            
        }

        string situacao = "";
        int verifSituacao = 0;

        private void rbtSim_CheckedChanged(object sender, EventArgs e)
        {
            rbtSim.Checked = true;

            if (rbtSim.Checked != false)
                situacao = "S";
            verifSituacao +=1 ;
        }

        private void rbtNao_CheckedChanged(object sender, EventArgs e)
        {
            rbtNao.Checked = true;

            if (rbtNao.Checked != false)
                situacao = "N";
            verifSituacao += 1;
        }
    }
}
