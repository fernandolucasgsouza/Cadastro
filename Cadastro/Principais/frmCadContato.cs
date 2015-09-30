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
    public partial class frmCadContato : Form
    {
        public frmCadContato()
        {
            InitializeComponent();
        }

        //Button responsável por fechar (frmCadContato)
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        //Método responsável em adcionar o contato no banco
        private void btnAdiciona_Click(object sender, EventArgs e)
        {
            ContatoDAO dao = new ContatoDAO();

            varreCampoCad();

            string sexo = "ND";

            if (rdoBtnMasc.Checked)
                sexo = rdoBtnMasc.Text;
            else
                sexo = rdoBtnFem.Text;

            if (contador != 0)
            {
                MessageBox.Show("Você deve preencher: "+ contador + " campos.\n Para concluir o cadastro.","Atenção",MessageBoxButtons.OK,MessageBoxIcon.Information);
                contador = 0;
            }
            //Se passar por todas as condições entao ele adciona no banco
            else
            {
                Contato c = new Contato()
                {
                    Nome = textNome.Text,
                    DataNascimento = textData.Text,
                    Email = textEmail.Text,
                    Sexo = sexo,
                    Cep = myMaskedTextCEP.Text,
                    Logradoouro = textLogradouro.Text,
                    Numero = textNumero.Text,
                    Bairro = textBairro.Text,
                    Municipio = textMunicipio.Text,
                    Uf = textUF.Text,
                };

                dao.Adiciona(c);

                limpaCampo();

            }
        }

        //String responsável por contar campos não preenchidos
        int contador = 0;
        public void varreCampoCad()
        {
            //Condição responsável por verificar se o campo (Nome) está preenchido
            if (string.IsNullOrEmpty(textNome.Text))
            {
                MessageBox.Show("O campo (Nome) não foi preenchido.\nVerifique o campo e insira os dados completos.",
                   "Erro de Inserção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                contador++;
            }
            //Condição responsável por verificar se o campo (Data de Nascimento) está preenchido
            if (string.IsNullOrEmpty(textData.Text))
            {
                MessageBox.Show("O campo (Data de Nascimento) não foi preenchido.\nVerifique o campo e insira os dados completos.",
                   "Erro de Inserção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                contador++;
            }
            //Condição responsável por verificar se o campo (Email) está preenchido
            if (string.IsNullOrEmpty(textEmail.Text))
            {
                MessageBox.Show("O campo (Email) não foi preenchido.\nVerifique o campo e insira os dados completos.",
                  "Erro de Inserção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                contador++;
            }
            //Condição responsável por verificar se o campo (cep) está preenchido
            if (myMaskedTextCEP.Text.Length < 9)
            {
                MessageBox.Show("O CEP: (" + myMaskedTextCEP.Text + ") está imcompleto\nVerifique o campo e insira os dados completos.",
                    "Erro de Inserção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                contador++;
            }
            //Condição responsável por verificar se o campo(Logradouro) está preenchido
            if (string.IsNullOrEmpty(textLogradouro.Text))
            {
                MessageBox.Show("O campo (Rua / Av.) não foi preenchido.\nVerifique o campo e insira os dados completos.",
                  "Erro de Inserção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                contador++;
            }
            //Condição responsável por verificar se o campo (Numero) está preenchido
            if (string.IsNullOrEmpty(textNumero.Text))
            {
                MessageBox.Show("O campo (Numero Residencial) não foi preenchido.\nVerifique o campo e insira os dados completos.",
                  "Erro de Inserção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                contador++;
            }
            //Condição responsável por verificar se o campo (Bairro) está preenchido
            if (string.IsNullOrEmpty(textBairro.Text))
            {
                MessageBox.Show("O campo (Bairro) não foi preenchido.\nVerifique o campo e insira os dados completos.",
                  "Erro de Inserção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                contador++;
            }
            //Condição responsável por verificar se o campo (Municipio) está preenchido
            if (string.IsNullOrEmpty(textMunicipio.Text))
            {
                MessageBox.Show("O campo (Município) não foi preenchido.\nVerifique o campo e insira os dados completos.",
                  "Erro de Inserção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                contador++;
            }
            //Condição responsável por verificar se o campo (Uf) está preenchido
            if (string.IsNullOrEmpty(textUF.Text))
            {
                MessageBox.Show("O campo (Uf) não foi preenchido.\nVerifique o campo e insira os dados completos.",
                  "Erro de Inserção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                contador++;
            }
            
        }


        //Método responsável em limpar os textBox
        public void limpaCampo()
        {
            textNome.Clear();
            textData.Clear();
            textEmail.Clear();
            myMaskedTextCEP.Clear();
            textLogradouro.Clear();
            textNumero.Clear();
            textBairro.Clear();
            textMunicipio.Clear();
            textUF.Clear();
                         
        }

        //Método responsável pela visualização do calendário
        private void chBoxCalendario_CheckedChanged(object sender, EventArgs e)
        {
            //se checkbox estiver ckecked exibe calendar senão não exibe
            if (chBoxCalendario.Checked)
                monthCalendar1.Visible = true;
            else
                monthCalendar1.Visible = false;
        }

        //Formatação do calendar
        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            textData.Text = monthCalendar1.SelectionStart.ToString("dd/MM/yyyy");
        }

        //Define uma mascara para o CEP incluindo as literais no banco
        private void myMaskedTextCEP_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            myMaskedTextCEP.TextMaskFormat = MaskFormat.IncludeLiterals;

        }

        //Button responsável por fechar (frmCadContato)
        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Método responsável por fechar o calendar quando o foco estiver no textbox (textEmail)
        private void textEmail_Enter(object sender, EventArgs e)
        {
            this.monthCalendar1.Visible = false;
            this.chBoxCalendario.Checked = false;
        }
        //Método responsável por fechar o calendar quando o foco estiver no textbox (textNome)
        private void textNome_Enter(object sender, EventArgs e)
        {
            this.monthCalendar1.Visible = false;
            this.chBoxCalendario.Checked = false;
        }
        //Chamar a próxima aba do tabpage
        private void btnProximo_Click(object sender, EventArgs e)
        {
            tabPageContdadosPessoais.SelectedTab = tabPageEndereco;
        }
        //Chamar aba anterior do tabpage
        private void btnVoltar_Click(object sender, EventArgs e)
        {
            tabPageContdadosPessoais.SelectedTab = tabPageDadosPessoais;
        }
    }
}
