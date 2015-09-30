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
    public partial class frmListContato : Form
    {
        public frmListContato()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'agendaDataSet.Contatoes' table. You can move, or remove it, as needed.
            this.contatoesTableAdapter.Fill(this.agendaDataSet.Contatoes);
            listarContatos();
        }

        //Listar todos os contatos cadastrados no banco
        private void listarContatos()
        {
            ContatoDAO daoLista = new ContatoDAO();

            dgvContatos.DataSource = daoLista.Lista();
        }

        //Excluir um contato da lista no banco de dados
        private void btnExcluir_Click(object sender, EventArgs e)
        {
           if(MessageBox.Show("Deseja Excluir?\n\n"
                + dgvContatos.CurrentRow.Cells[1].Value.ToString(), "Atenção", 
                MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.OK)
            {
                Contato contato = new Contato();            
                ContatoDAO daoRemove = new ContatoDAO();

                contato = daoRemove.BuscaId(Int32.Parse(dgvContatos.CurrentRow.Cells[0].Value.ToString()));

                daoRemove.Remove(contato);

                listarContatos();
            }
        }

        //Chamar a tela de de Alteração PanelAterar
        private void btnAlterar_Click(object sender, EventArgs e)
        {
            panelAlterar.Visible = true;
            btnFechar.Visible = false;
            btnExcluir.Visible = false;
            btnAlterar.Visible = false;
        }

        //Button fechar tela de frmListContatos
        private void btnFechar_Click_1(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        //Pesquisar contato através do preencimento dos textBoxs
        private void txtPesqNome_TextChanged(object sender, EventArgs e)
        {
            ContatoDAO dao = new ContatoDAO();

            dgvContatos.DataSource = dao.BuscaPorNome(txtPesqNome.Text,
                txtPesqDataNascimento.Text,
                txtPesqSexo.Text,
                txtPesqEmail.Text,
                txtPesqCep.Text,
                txtPesqLogradouro.Text, 
                txtPesqNumero.Text,
                txtPesqBairro.Text,
                txtPesqMunicipio.Text,
                txtPesqUf.Text);
        }

//-------------------------------------------Tela de Alterar------------------------------------------------------------------------------------------------
        
        //Selciona grid e entrega para os txtBoxs
        private void dgvContatos_SelectionChanged(object sender, EventArgs e)
        {
            textAlteraNome.Text = dgvContatos.CurrentRow.Cells[1].Value.ToString();
            textAlteraDtNascimento.Text = dgvContatos.CurrentRow.Cells[2].Value.ToString();
            textAlteraSexo.Text = dgvContatos.CurrentRow.Cells[3].Value.ToString();
            textAlteraEmail.Text = dgvContatos.CurrentRow.Cells[4].Value.ToString();
            mkdTexAlteraCEP.Text = dgvContatos.CurrentRow.Cells[5].Value.ToString();
            textAlteraLogradouro.Text = dgvContatos.CurrentRow.Cells[6].Value.ToString();
            textAlteraNumero.Text = dgvContatos.CurrentRow.Cells[7].Value.ToString();
            textAlteraBairro.Text = dgvContatos.CurrentRow.Cells[8].Value.ToString();
            textAlteraMunicipio.Text = dgvContatos.CurrentRow.Cells[9].Value.ToString();
            textAlteraUf.Text = dgvContatos.CurrentRow.Cells[10].Value.ToString();

            //radio button recebe o texto do banco 
            if (textAlteraSexo.Text.Equals("M"))
                rdoBtnAlteraMasculino.Checked = true;
            else
                rdoBtnAlteraFeminino.Checked = true;
        }

        //Button salvar tela alterar Panel1
        private void btnSalva_Click(object sender, EventArgs e)
        {
            ContatoDAO daoAltera = new ContatoDAO();

            int buscaId = Int32.Parse(dgvContatos.CurrentRow.Cells[0].Value.ToString());
            string sexo = "";

            if (rdoBtnAlteraMasculino.Checked)
                sexo = rdoBtnAlteraMasculino.Text;
            else
                sexo = rdoBtnAlteraFeminino.Text;
            
            Contato cAltera = new Contato() {
                Id = buscaId,
                Nome = textAlteraNome.Text,
                DataNascimento = textAlteraDtNascimento.Text,
                Email = textAlteraEmail.Text,
                Sexo = sexo,
                Cep = mkdTexAlteraCEP.Text,
                Logradoouro = textAlteraLogradouro.Text,
                Numero = textAlteraNumero.Text,
                Bairro = textAlteraBairro.Text,
                Municipio = textAlteraMunicipio.Text,
                Uf = textAlteraUf.Text,

            };

            daoAltera.Altera(cAltera);

            MessageBox.Show("Contato Alterado com Sucesso!","Aviso",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);

            panelAlterar.Visible = false;

            ClearCampoPesquisa();

            btnFechar.Visible = true;
            btnExcluir.Visible = true;
            btnAlterar.Visible = true;
        }

        //Button fechar tela alterar Panel1
        private void btnCancelarAlteracao_Click(object sender, EventArgs e)
        {
            panelAlterar.Visible = false;
            btnFechar.Visible = true;
            btnExcluir.Visible = true;
            btnAlterar.Visible = true;
        }

        private void btnClearPesquisa_Click(object sender, EventArgs e)
        {
            ClearCampoPesquisa();
        }

        public void ClearCampoPesquisa()
        {
            txtPesqNome.Clear();
            txtPesqDataNascimento.Clear();
            txtPesqEmail.Clear();
            txtPesqSexo.Clear();
            txtPesqCep.Clear();
            txtPesqLogradouro.Clear();
            txtPesqNumero.Clear();
            txtPesqBairro.Clear();
            txtPesqMunicipio.Clear();
            txtPesqUf.Clear();
        }
      
    }
}
