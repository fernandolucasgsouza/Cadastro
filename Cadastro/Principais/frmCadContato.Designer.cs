namespace Cadastro
{
    partial class frmCadContato
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadContato));
            this.lblLogradouro = new System.Windows.Forms.Label();
            this.lblBairro = new System.Windows.Forms.Label();
            this.lblUf = new System.Windows.Forms.Label();
            this.lblMunicipio = new System.Windows.Forms.Label();
            this.btnAdiciona = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnFechar = new System.Windows.Forms.Button();
            this.tabPageContdadosPessoais = new System.Windows.Forms.TabControl();
            this.tabPageDadosPessoais = new System.Windows.Forms.TabPage();
            this.btnProximo = new System.Windows.Forms.Button();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.textEmail = new Cadastro.MyTextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rdoBtnMasc = new System.Windows.Forms.RadioButton();
            this.rdoBtnFem = new System.Windows.Forms.RadioButton();
            this.chBoxCalendario = new System.Windows.Forms.CheckBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblDataNascimento = new System.Windows.Forms.Label();
            this.textNome = new Cadastro.MyTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabPageEndereco = new System.Windows.Forms.TabPage();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.myMaskedTextCEP = new Cadastro.MyMaskedTextBox();
            this.lblCEP = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textNumero = new Cadastro.MyTextBox();
            this.textUF = new Cadastro.MyTextBox();
            this.textMunicipio = new Cadastro.MyTextBox();
            this.textBairro = new Cadastro.MyTextBox();
            this.textLogradouro = new Cadastro.MyTextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.textData = new Cadastro.MyMaskedTextBox();
            this.panel1.SuspendLayout();
            this.tabPageContdadosPessoais.SuspendLayout();
            this.tabPageDadosPessoais.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPageEndereco.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblLogradouro
            // 
            this.lblLogradouro.AutoSize = true;
            this.lblLogradouro.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogradouro.ForeColor = System.Drawing.Color.Navy;
            this.lblLogradouro.Location = new System.Drawing.Point(76, 147);
            this.lblLogradouro.Name = "lblLogradouro";
            this.lblLogradouro.Size = new System.Drawing.Size(63, 18);
            this.lblLogradouro.TabIndex = 2;
            this.lblLogradouro.Text = "Av / Rua";
            // 
            // lblBairro
            // 
            this.lblBairro.AutoSize = true;
            this.lblBairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBairro.ForeColor = System.Drawing.Color.Navy;
            this.lblBairro.Location = new System.Drawing.Point(91, 207);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(48, 18);
            this.lblBairro.TabIndex = 3;
            this.lblBairro.Text = "Bairro";
            // 
            // lblUf
            // 
            this.lblUf.AutoSize = true;
            this.lblUf.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUf.ForeColor = System.Drawing.Color.Navy;
            this.lblUf.Location = new System.Drawing.Point(111, 344);
            this.lblUf.Name = "lblUf";
            this.lblUf.Size = new System.Drawing.Size(28, 18);
            this.lblUf.TabIndex = 4;
            this.lblUf.Text = "UF";
            // 
            // lblMunicipio
            // 
            this.lblMunicipio.AutoSize = true;
            this.lblMunicipio.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lblMunicipio.ForeColor = System.Drawing.Color.Navy;
            this.lblMunicipio.Location = new System.Drawing.Point(68, 285);
            this.lblMunicipio.Name = "lblMunicipio";
            this.lblMunicipio.Size = new System.Drawing.Size(71, 18);
            this.lblMunicipio.TabIndex = 8;
            this.lblMunicipio.Text = "Munícipio";
            // 
            // btnAdiciona
            // 
            this.btnAdiciona.BackColor = System.Drawing.Color.SteelBlue;
            this.btnAdiciona.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdiciona.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnAdiciona.Location = new System.Drawing.Point(843, 477);
            this.btnAdiciona.Name = "btnAdiciona";
            this.btnAdiciona.Size = new System.Drawing.Size(130, 50);
            this.btnAdiciona.TabIndex = 14;
            this.btnAdiciona.Text = "Salvar";
            this.toolTip1.SetToolTip(this.btnAdiciona, "Salvar");
            this.btnAdiciona.UseVisualStyleBackColor = false;
            this.btnAdiciona.Click += new System.EventHandler(this.btnAdiciona_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.IndianRed;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnCancelar.Location = new System.Drawing.Point(695, 620);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(130, 50);
            this.btnCancelar.TabIndex = 16;
            this.btnCancelar.Text = "Cancelar";
            this.toolTip1.SetToolTip(this.btnCancelar, "Cancelar");
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 20;
            // 
            // panel1
            // 
            this.panel1.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.panel1.Controls.Add(this.btnFechar);
            this.panel1.Controls.Add(this.tabPageContdadosPessoais);
            this.panel1.Controls.Add(this.btnCancelar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1064, 682);
            this.panel1.TabIndex = 19;
            // 
            // btnFechar
            // 
            this.btnFechar.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnFechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFechar.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnFechar.Image = ((System.Drawing.Image)(resources.GetObject("btnFechar.Image")));
            this.btnFechar.Location = new System.Drawing.Point(877, 620);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(130, 50);
            this.btnFechar.TabIndex = 15;
            this.toolTip1.SetToolTip(this.btnFechar, "Sair da Tela de Cadastro");
            this.btnFechar.UseVisualStyleBackColor = false;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // tabPageContdadosPessoais
            // 
            this.tabPageContdadosPessoais.Controls.Add(this.tabPageDadosPessoais);
            this.tabPageContdadosPessoais.Controls.Add(this.tabPageEndereco);
            this.tabPageContdadosPessoais.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPageContdadosPessoais.Location = new System.Drawing.Point(30, 28);
            this.tabPageContdadosPessoais.Name = "tabPageContdadosPessoais";
            this.tabPageContdadosPessoais.SelectedIndex = 0;
            this.tabPageContdadosPessoais.Size = new System.Drawing.Size(1000, 577);
            this.tabPageContdadosPessoais.TabIndex = 0;
            // 
            // tabPageDadosPessoais
            // 
            this.tabPageDadosPessoais.Controls.Add(this.textData);
            this.tabPageDadosPessoais.Controls.Add(this.btnProximo);
            this.tabPageDadosPessoais.Controls.Add(this.monthCalendar1);
            this.tabPageDadosPessoais.Controls.Add(this.textEmail);
            this.tabPageDadosPessoais.Controls.Add(this.lblEmail);
            this.tabPageDadosPessoais.Controls.Add(this.groupBox1);
            this.tabPageDadosPessoais.Controls.Add(this.chBoxCalendario);
            this.tabPageDadosPessoais.Controls.Add(this.lblNome);
            this.tabPageDadosPessoais.Controls.Add(this.lblDataNascimento);
            this.tabPageDadosPessoais.Controls.Add(this.textNome);
            this.tabPageDadosPessoais.Controls.Add(this.pictureBox1);
            this.tabPageDadosPessoais.ForeColor = System.Drawing.Color.Navy;
            this.tabPageDadosPessoais.Location = new System.Drawing.Point(4, 25);
            this.tabPageDadosPessoais.Name = "tabPageDadosPessoais";
            this.tabPageDadosPessoais.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDadosPessoais.Size = new System.Drawing.Size(992, 548);
            this.tabPageDadosPessoais.TabIndex = 0;
            this.tabPageDadosPessoais.Text = "Dados Pessoais";
            this.tabPageDadosPessoais.UseVisualStyleBackColor = true;
            // 
            // btnProximo
            // 
            this.btnProximo.BackColor = System.Drawing.Color.SteelBlue;
            this.btnProximo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProximo.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnProximo.Location = new System.Drawing.Point(843, 478);
            this.btnProximo.Name = "btnProximo";
            this.btnProximo.Size = new System.Drawing.Size(130, 50);
            this.btnProximo.TabIndex = 17;
            this.btnProximo.Text = "Próximo";
            this.toolTip1.SetToolTip(this.btnProximo, "Cancelar");
            this.btnProximo.UseVisualStyleBackColor = false;
            this.btnProximo.Click += new System.EventHandler(this.btnProximo_Click);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(374, 151);
            this.monthCalendar1.MaxSelectionCount = 1;
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 0;
            this.monthCalendar1.Visible = false;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // textEmail
            // 
            this.textEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEmail.Location = new System.Drawing.Point(157, 197);
            this.textEmail.Name = "textEmail";
            this.textEmail.Size = new System.Drawing.Size(444, 24);
            this.textEmail.TabIndex = 7;
            this.textEmail.Enter += new System.EventHandler(this.textEmail_Enter);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.Color.Navy;
            this.lblEmail.Location = new System.Drawing.Point(106, 201);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(45, 18);
            this.lblEmail.TabIndex = 19;
            this.lblEmail.Text = "Email";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.rdoBtnMasc);
            this.groupBox1.Controls.Add(this.rdoBtnFem);
            this.groupBox1.ForeColor = System.Drawing.Color.Navy;
            this.groupBox1.Location = new System.Drawing.Point(710, 99);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(176, 188);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sexo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(74, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "(Femínino)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(74, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "(Masculíno)";
            // 
            // rdoBtnMasc
            // 
            this.rdoBtnMasc.AutoSize = true;
            this.rdoBtnMasc.Checked = true;
            this.rdoBtnMasc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoBtnMasc.ForeColor = System.Drawing.Color.Navy;
            this.rdoBtnMasc.Location = new System.Drawing.Point(32, 68);
            this.rdoBtnMasc.Name = "rdoBtnMasc";
            this.rdoBtnMasc.Size = new System.Drawing.Size(39, 22);
            this.rdoBtnMasc.TabIndex = 5;
            this.rdoBtnMasc.TabStop = true;
            this.rdoBtnMasc.Text = "M";
            this.rdoBtnMasc.UseVisualStyleBackColor = true;
            // 
            // rdoBtnFem
            // 
            this.rdoBtnFem.AutoSize = true;
            this.rdoBtnFem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoBtnFem.ForeColor = System.Drawing.Color.Navy;
            this.rdoBtnFem.Location = new System.Drawing.Point(32, 105);
            this.rdoBtnFem.Name = "rdoBtnFem";
            this.rdoBtnFem.Size = new System.Drawing.Size(35, 22);
            this.rdoBtnFem.TabIndex = 6;
            this.rdoBtnFem.Text = "F";
            this.rdoBtnFem.UseVisualStyleBackColor = true;
            // 
            // chBoxCalendario
            // 
            this.chBoxCalendario.AutoSize = true;
            this.chBoxCalendario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chBoxCalendario.ForeColor = System.Drawing.Color.Navy;
            this.chBoxCalendario.Location = new System.Drawing.Point(273, 153);
            this.chBoxCalendario.Name = "chBoxCalendario";
            this.chBoxCalendario.Size = new System.Drawing.Size(98, 22);
            this.chBoxCalendario.TabIndex = 3;
            this.chBoxCalendario.Text = "Calendário";
            this.chBoxCalendario.UseVisualStyleBackColor = true;
            this.chBoxCalendario.CheckedChanged += new System.EventHandler(this.chBoxCalendario_CheckedChanged);
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.ForeColor = System.Drawing.Color.Navy;
            this.lblNome.Location = new System.Drawing.Point(102, 105);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(49, 18);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome";
            // 
            // lblDataNascimento
            // 
            this.lblDataNascimento.AutoSize = true;
            this.lblDataNascimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataNascimento.ForeColor = System.Drawing.Color.Navy;
            this.lblDataNascimento.Location = new System.Drawing.Point(28, 157);
            this.lblDataNascimento.Name = "lblDataNascimento";
            this.lblDataNascimento.Size = new System.Drawing.Size(123, 18);
            this.lblDataNascimento.TabIndex = 1;
            this.lblDataNascimento.Text = "Data Nascimento";
            // 
            // textNome
            // 
            this.textNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textNome.Location = new System.Drawing.Point(157, 99);
            this.textNome.Name = "textNome";
            this.textNome.Size = new System.Drawing.Size(444, 24);
            this.textNome.TabIndex = 1;
            this.textNome.Enter += new System.EventHandler(this.textNome_Enter);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(986, 542);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // tabPageEndereco
            // 
            this.tabPageEndereco.Controls.Add(this.btnVoltar);
            this.tabPageEndereco.Controls.Add(this.myMaskedTextCEP);
            this.tabPageEndereco.Controls.Add(this.lblCEP);
            this.tabPageEndereco.Controls.Add(this.label2);
            this.tabPageEndereco.Controls.Add(this.btnAdiciona);
            this.tabPageEndereco.Controls.Add(this.lblLogradouro);
            this.tabPageEndereco.Controls.Add(this.lblMunicipio);
            this.tabPageEndereco.Controls.Add(this.lblUf);
            this.tabPageEndereco.Controls.Add(this.lblBairro);
            this.tabPageEndereco.Controls.Add(this.textNumero);
            this.tabPageEndereco.Controls.Add(this.textUF);
            this.tabPageEndereco.Controls.Add(this.textMunicipio);
            this.tabPageEndereco.Controls.Add(this.textBairro);
            this.tabPageEndereco.Controls.Add(this.textLogradouro);
            this.tabPageEndereco.Controls.Add(this.pictureBox2);
            this.tabPageEndereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPageEndereco.ForeColor = System.Drawing.Color.Navy;
            this.tabPageEndereco.Location = new System.Drawing.Point(4, 25);
            this.tabPageEndereco.Name = "tabPageEndereco";
            this.tabPageEndereco.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageEndereco.Size = new System.Drawing.Size(992, 548);
            this.tabPageEndereco.TabIndex = 1;
            this.tabPageEndereco.Text = "Endereço";
            this.tabPageEndereco.UseVisualStyleBackColor = true;
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.Color.Coral;
            this.btnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnVoltar.Location = new System.Drawing.Point(32, 477);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(130, 50);
            this.btnVoltar.TabIndex = 17;
            this.btnVoltar.Text = "Voltar";
            this.toolTip1.SetToolTip(this.btnVoltar, "Cancelar");
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // myMaskedTextCEP
            // 
            this.myMaskedTextCEP.BackColor = System.Drawing.Color.White;
            this.myMaskedTextCEP.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myMaskedTextCEP.Location = new System.Drawing.Point(145, 94);
            this.myMaskedTextCEP.Mask = "00000-000";
            this.myMaskedTextCEP.Name = "myMaskedTextCEP";
            this.myMaskedTextCEP.PromptChar = 'x';
            this.myMaskedTextCEP.Size = new System.Drawing.Size(272, 24);
            this.myMaskedTextCEP.TabIndex = 8;
            this.myMaskedTextCEP.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.myMaskedTextCEP_MaskInputRejected);
            // 
            // lblCEP
            // 
            this.lblCEP.AutoSize = true;
            this.lblCEP.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCEP.ForeColor = System.Drawing.Color.Navy;
            this.lblCEP.Location = new System.Drawing.Point(100, 94);
            this.lblCEP.Name = "lblCEP";
            this.lblCEP.Size = new System.Drawing.Size(39, 18);
            this.lblCEP.TabIndex = 16;
            this.lblCEP.Text = "CEP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(443, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 18);
            this.label2.TabIndex = 14;
            this.label2.Text = "Numero";
            // 
            // textNumero
            // 
            this.textNumero.Location = new System.Drawing.Point(511, 143);
            this.textNumero.Name = "textNumero";
            this.textNumero.Size = new System.Drawing.Size(100, 22);
            this.textNumero.TabIndex = 10;
            // 
            // textUF
            // 
            this.textUF.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textUF.Location = new System.Drawing.Point(145, 344);
            this.textUF.Name = "textUF";
            this.textUF.Size = new System.Drawing.Size(75, 24);
            this.textUF.TabIndex = 13;
            // 
            // textMunicipio
            // 
            this.textMunicipio.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textMunicipio.Location = new System.Drawing.Point(145, 279);
            this.textMunicipio.Name = "textMunicipio";
            this.textMunicipio.Size = new System.Drawing.Size(272, 24);
            this.textMunicipio.TabIndex = 12;
            // 
            // textBairro
            // 
            this.textBairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBairro.Location = new System.Drawing.Point(145, 207);
            this.textBairro.Name = "textBairro";
            this.textBairro.Size = new System.Drawing.Size(272, 24);
            this.textBairro.TabIndex = 11;
            // 
            // textLogradouro
            // 
            this.textLogradouro.BackColor = System.Drawing.Color.White;
            this.textLogradouro.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textLogradouro.Location = new System.Drawing.Point(145, 147);
            this.textLogradouro.Name = "textLogradouro";
            this.textLogradouro.Size = new System.Drawing.Size(272, 24);
            this.textLogradouro.TabIndex = 9;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(3, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(986, 542);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            // 
            // textData
            // 
            this.textData.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textData.Location = new System.Drawing.Point(157, 154);
            this.textData.Mask = "00/00/0000";
            this.textData.Name = "textData";
            this.textData.Size = new System.Drawing.Size(110, 24);
            this.textData.TabIndex = 2;
            // 
            // frmCadContato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1064, 682);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCadContato";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Novo Contato";
            this.panel1.ResumeLayout(false);
            this.tabPageContdadosPessoais.ResumeLayout(false);
            this.tabPageDadosPessoais.ResumeLayout(false);
            this.tabPageDadosPessoais.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPageEndereco.ResumeLayout(false);
            this.tabPageEndereco.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblLogradouro;
        private System.Windows.Forms.Label lblBairro;
        private System.Windows.Forms.Label lblUf;
        private System.Windows.Forms.Button btnAdiciona;
        private System.Windows.Forms.Button btnCancelar;
        private MyTextBox textUF;
        private MyTextBox textBairro;
        private MyTextBox textLogradouro;
        private MyTextBox textMunicipio;
        private System.Windows.Forms.Label lblMunicipio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tabPageContdadosPessoais;
        private System.Windows.Forms.TabPage tabPageEndereco;
        private System.Windows.Forms.TabPage tabPageDadosPessoais;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdoBtnMasc;
        private System.Windows.Forms.RadioButton rdoBtnFem;
        private System.Windows.Forms.CheckBox chBoxCalendario;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblDataNascimento;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private MyTextBox textNome;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private MyTextBox textNumero;
        private System.Windows.Forms.Label label2;
        private MyTextBox textEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblCEP;
        private MyMaskedTextBox myMaskedTextCEP;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnProximo;
        private System.Windows.Forms.Button btnVoltar;
        private MyMaskedTextBox textData;
    }
}

