namespace Cadastro
{
    partial class frmListContato
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListContato));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelAlterar = new System.Windows.Forms.Panel();
            this.btnCancelarAlteracao = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdoBtnAlteraFeminino = new System.Windows.Forms.RadioButton();
            this.rdoBtnAlteraMasculino = new System.Windows.Forms.RadioButton();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSalva = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.groupBoxPesquisa = new System.Windows.Forms.GroupBox();
            this.btnClearPesquisa = new System.Windows.Forms.Button();
            this.txtPesqMunicipio = new System.Windows.Forms.TextBox();
            this.lblPesqBairro = new System.Windows.Forms.Label();
            this.txtPesqDataNascimento = new System.Windows.Forms.TextBox();
            this.lblPesqDataNascimento = new System.Windows.Forms.Label();
            this.txtPesqUf = new System.Windows.Forms.TextBox();
            this.lblPesqUf = new System.Windows.Forms.Label();
            this.txtPesqNumero = new System.Windows.Forms.TextBox();
            this.lblPesqNumero = new System.Windows.Forms.Label();
            this.txtPesqEmail = new System.Windows.Forms.TextBox();
            this.lblPesqEmail = new System.Windows.Forms.Label();
            this.lblPesqLogradouro = new System.Windows.Forms.Label();
            this.txtPesqLogradouro = new System.Windows.Forms.TextBox();
            this.lblPesqMunicipio = new System.Windows.Forms.Label();
            this.lblPesqCep = new System.Windows.Forms.Label();
            this.lblPesqSexo = new System.Windows.Forms.Label();
            this.txtPesqBairro = new System.Windows.Forms.TextBox();
            this.txtPesqCep = new System.Windows.Forms.TextBox();
            this.txtPesqSexo = new System.Windows.Forms.TextBox();
            this.lblPesqNome = new System.Windows.Forms.Label();
            this.txtPesqNome = new System.Windows.Forms.TextBox();
            this.dgvContatos = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contatoesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.agendaDataSet = new Cadastro.AgendaDataSet();
            this.agendaDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.contatoesTableAdapter = new Cadastro.AgendaDataSetTableAdapters.ContatoesTableAdapter();
            this.tableAdapterManager = new Cadastro.AgendaDataSetTableAdapters.TableAdapterManager();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.textAlteraDtNascimento = new Cadastro.MyMaskedTextBox();
            this.mkdTexAlteraCEP = new Cadastro.MyMaskedTextBox();
            this.textAlteraSexo = new Cadastro.MyTextBox();
            this.textAlteraUf = new Cadastro.MyTextBox();
            this.textAlteraMunicipio = new Cadastro.MyTextBox();
            this.textAlteraBairro = new Cadastro.MyTextBox();
            this.textAlteraNumero = new Cadastro.MyTextBox();
            this.textAlteraLogradouro = new Cadastro.MyTextBox();
            this.textAlteraEmail = new Cadastro.MyTextBox();
            this.textAlteraNome = new Cadastro.MyTextBox();
            this.panel1.SuspendLayout();
            this.panelAlterar.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBoxPesquisa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contatoesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agendaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agendaDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.panel1.Controls.Add(this.panelAlterar);
            this.panel1.Controls.Add(this.btnFechar);
            this.panel1.Controls.Add(this.btnAlterar);
            this.panel1.Controls.Add(this.btnExcluir);
            this.panel1.Controls.Add(this.groupBoxPesquisa);
            this.panel1.Controls.Add(this.dgvContatos);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1355, 636);
            this.panel1.TabIndex = 21;
            // 
            // panelAlterar
            // 
            this.panelAlterar.BackColor = System.Drawing.Color.White;
            this.panelAlterar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelAlterar.Controls.Add(this.textAlteraDtNascimento);
            this.panelAlterar.Controls.Add(this.btnCancelarAlteracao);
            this.panelAlterar.Controls.Add(this.mkdTexAlteraCEP);
            this.panelAlterar.Controls.Add(this.groupBox1);
            this.panelAlterar.Controls.Add(this.textAlteraUf);
            this.panelAlterar.Controls.Add(this.textAlteraMunicipio);
            this.panelAlterar.Controls.Add(this.textAlteraBairro);
            this.panelAlterar.Controls.Add(this.textAlteraNumero);
            this.panelAlterar.Controls.Add(this.textAlteraLogradouro);
            this.panelAlterar.Controls.Add(this.textAlteraEmail);
            this.panelAlterar.Controls.Add(this.textAlteraNome);
            this.panelAlterar.Controls.Add(this.label9);
            this.panelAlterar.Controls.Add(this.label8);
            this.panelAlterar.Controls.Add(this.label7);
            this.panelAlterar.Controls.Add(this.label6);
            this.panelAlterar.Controls.Add(this.label5);
            this.panelAlterar.Controls.Add(this.label4);
            this.panelAlterar.Controls.Add(this.label3);
            this.panelAlterar.Controls.Add(this.label2);
            this.panelAlterar.Controls.Add(this.label1);
            this.panelAlterar.Controls.Add(this.btnSalva);
            this.panelAlterar.Location = new System.Drawing.Point(307, 24);
            this.panelAlterar.Name = "panelAlterar";
            this.panelAlterar.Size = new System.Drawing.Size(706, 586);
            this.panelAlterar.TabIndex = 23;
            this.panelAlterar.Visible = false;
            // 
            // btnCancelarAlteracao
            // 
            this.btnCancelarAlteracao.BackColor = System.Drawing.Color.IndianRed;
            this.btnCancelarAlteracao.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarAlteracao.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnCancelarAlteracao.Location = new System.Drawing.Point(534, 383);
            this.btnCancelarAlteracao.Name = "btnCancelarAlteracao";
            this.btnCancelarAlteracao.Size = new System.Drawing.Size(130, 50);
            this.btnCancelarAlteracao.TabIndex = 33;
            this.btnCancelarAlteracao.Text = "Cancelar";
            this.toolTip1.SetToolTip(this.btnCancelarAlteracao, "Após o clicar toda alteração será desfeita");
            this.btnCancelarAlteracao.UseVisualStyleBackColor = false;
            this.btnCancelarAlteracao.Click += new System.EventHandler(this.btnCancelarAlteracao_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textAlteraSexo);
            this.groupBox1.Controls.Add(this.rdoBtnAlteraFeminino);
            this.groupBox1.Controls.Add(this.rdoBtnAlteraMasculino);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.groupBox1.Location = new System.Drawing.Point(524, 65);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(140, 126);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sexo";
            // 
            // rdoBtnAlteraFeminino
            // 
            this.rdoBtnAlteraFeminino.AutoSize = true;
            this.rdoBtnAlteraFeminino.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoBtnAlteraFeminino.Location = new System.Drawing.Point(15, 76);
            this.rdoBtnAlteraFeminino.Name = "rdoBtnAlteraFeminino";
            this.rdoBtnAlteraFeminino.Size = new System.Drawing.Size(35, 22);
            this.rdoBtnAlteraFeminino.TabIndex = 12;
            this.rdoBtnAlteraFeminino.TabStop = true;
            this.rdoBtnAlteraFeminino.Text = "F";
            this.rdoBtnAlteraFeminino.UseVisualStyleBackColor = true;
            // 
            // rdoBtnAlteraMasculino
            // 
            this.rdoBtnAlteraMasculino.AutoSize = true;
            this.rdoBtnAlteraMasculino.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoBtnAlteraMasculino.Location = new System.Drawing.Point(15, 34);
            this.rdoBtnAlteraMasculino.Name = "rdoBtnAlteraMasculino";
            this.rdoBtnAlteraMasculino.Size = new System.Drawing.Size(39, 22);
            this.rdoBtnAlteraMasculino.TabIndex = 11;
            this.rdoBtnAlteraMasculino.TabStop = true;
            this.rdoBtnAlteraMasculino.Text = "M";
            this.rdoBtnAlteraMasculino.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label9.Location = new System.Drawing.Point(102, 191);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 18);
            this.label9.TabIndex = 31;
            this.label9.Text = "Cep";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label8.Location = new System.Drawing.Point(113, 411);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(28, 18);
            this.label8.TabIndex = 30;
            this.label8.Text = "UF";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label7.Location = new System.Drawing.Point(70, 368);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 18);
            this.label7.TabIndex = 29;
            this.label7.Text = "Municipio";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label6.Location = new System.Drawing.Point(93, 324);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 18);
            this.label6.TabIndex = 28;
            this.label6.Text = "Bairro";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label5.Location = new System.Drawing.Point(75, 283);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 18);
            this.label5.TabIndex = 27;
            this.label5.Text = "Numero";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label4.Location = new System.Drawing.Point(69, 235);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 18);
            this.label4.TabIndex = 26;
            this.label4.Text = "Endereço";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label3.Location = new System.Drawing.Point(92, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 18);
            this.label3.TabIndex = 25;
            this.label3.Text = "Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label2.Location = new System.Drawing.Point(18, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 18);
            this.label2.TabIndex = 24;
            this.label2.Text = "Data Nascimento";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label1.Location = new System.Drawing.Point(92, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 18);
            this.label1.TabIndex = 23;
            this.label1.Text = "Nome";
            // 
            // btnSalva
            // 
            this.btnSalva.BackColor = System.Drawing.Color.SteelBlue;
            this.btnSalva.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalva.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnSalva.Location = new System.Drawing.Point(534, 453);
            this.btnSalva.Name = "btnSalva";
            this.btnSalva.Size = new System.Drawing.Size(130, 50);
            this.btnSalva.TabIndex = 13;
            this.btnSalva.Text = "Salvar";
            this.toolTip1.SetToolTip(this.btnSalva, "Registra os dados alterados no banco");
            this.btnSalva.UseVisualStyleBackColor = false;
            this.btnSalva.Click += new System.EventHandler(this.btnSalva_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnFechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFechar.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnFechar.Image = ((System.Drawing.Image)(resources.GetObject("btnFechar.Image")));
            this.btnFechar.Location = new System.Drawing.Point(1213, 570);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(130, 50);
            this.btnFechar.TabIndex = 14;
            this.toolTip1.SetToolTip(this.btnFechar, "Sair da Tela Pesquisa");
            this.btnFechar.UseVisualStyleBackColor = false;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click_1);
            // 
            // btnAlterar
            // 
            this.btnAlterar.BackColor = System.Drawing.Color.SandyBrown;
            this.btnAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterar.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnAlterar.Location = new System.Drawing.Point(914, 570);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(130, 50);
            this.btnAlterar.TabIndex = 12;
            this.btnAlterar.Text = "Alterar";
            this.toolTip1.SetToolTip(this.btnAlterar, "Alterar Contato");
            this.btnAlterar.UseVisualStyleBackColor = false;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.Color.SandyBrown;
            this.btnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnExcluir.Location = new System.Drawing.Point(1066, 570);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(130, 50);
            this.btnExcluir.TabIndex = 13;
            this.btnExcluir.Text = "Excluir";
            this.toolTip1.SetToolTip(this.btnExcluir, "Excluir Contato");
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // groupBoxPesquisa
            // 
            this.groupBoxPesquisa.Controls.Add(this.btnClearPesquisa);
            this.groupBoxPesquisa.Controls.Add(this.txtPesqMunicipio);
            this.groupBoxPesquisa.Controls.Add(this.lblPesqBairro);
            this.groupBoxPesquisa.Controls.Add(this.txtPesqDataNascimento);
            this.groupBoxPesquisa.Controls.Add(this.lblPesqDataNascimento);
            this.groupBoxPesquisa.Controls.Add(this.txtPesqUf);
            this.groupBoxPesquisa.Controls.Add(this.lblPesqUf);
            this.groupBoxPesquisa.Controls.Add(this.txtPesqNumero);
            this.groupBoxPesquisa.Controls.Add(this.lblPesqNumero);
            this.groupBoxPesquisa.Controls.Add(this.txtPesqEmail);
            this.groupBoxPesquisa.Controls.Add(this.lblPesqEmail);
            this.groupBoxPesquisa.Controls.Add(this.lblPesqLogradouro);
            this.groupBoxPesquisa.Controls.Add(this.txtPesqLogradouro);
            this.groupBoxPesquisa.Controls.Add(this.lblPesqMunicipio);
            this.groupBoxPesquisa.Controls.Add(this.lblPesqCep);
            this.groupBoxPesquisa.Controls.Add(this.lblPesqSexo);
            this.groupBoxPesquisa.Controls.Add(this.txtPesqBairro);
            this.groupBoxPesquisa.Controls.Add(this.txtPesqCep);
            this.groupBoxPesquisa.Controls.Add(this.txtPesqSexo);
            this.groupBoxPesquisa.Controls.Add(this.lblPesqNome);
            this.groupBoxPesquisa.Controls.Add(this.txtPesqNome);
            this.groupBoxPesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxPesquisa.ForeColor = System.Drawing.Color.White;
            this.groupBoxPesquisa.Location = new System.Drawing.Point(21, 6);
            this.groupBoxPesquisa.Name = "groupBoxPesquisa";
            this.groupBoxPesquisa.Size = new System.Drawing.Size(1322, 196);
            this.groupBoxPesquisa.TabIndex = 0;
            this.groupBoxPesquisa.TabStop = false;
            this.groupBoxPesquisa.Text = "Insira os dados que deseja pesquisar";
            // 
            // btnClearPesquisa
            // 
            this.btnClearPesquisa.BackColor = System.Drawing.Color.Transparent;
            this.btnClearPesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearPesquisa.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnClearPesquisa.Image = ((System.Drawing.Image)(resources.GetObject("btnClearPesquisa.Image")));
            this.btnClearPesquisa.Location = new System.Drawing.Point(1073, 134);
            this.btnClearPesquisa.Name = "btnClearPesquisa";
            this.btnClearPesquisa.Size = new System.Drawing.Size(130, 50);
            this.btnClearPesquisa.TabIndex = 24;
            this.toolTip1.SetToolTip(this.btnClearPesquisa, "Limpar Dados de Pesquisa");
            this.btnClearPesquisa.UseVisualStyleBackColor = false;
            this.btnClearPesquisa.Click += new System.EventHandler(this.btnClearPesquisa_Click);
            // 
            // txtPesqMunicipio
            // 
            this.txtPesqMunicipio.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesqMunicipio.Location = new System.Drawing.Point(649, 150);
            this.txtPesqMunicipio.Name = "txtPesqMunicipio";
            this.txtPesqMunicipio.Size = new System.Drawing.Size(269, 24);
            this.txtPesqMunicipio.TabIndex = 8;
            this.txtPesqMunicipio.TextChanged += new System.EventHandler(this.txtPesqNome_TextChanged);
            // 
            // lblPesqBairro
            // 
            this.lblPesqBairro.AutoSize = true;
            this.lblPesqBairro.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.lblPesqBairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPesqBairro.Location = new System.Drawing.Point(595, 154);
            this.lblPesqBairro.Name = "lblPesqBairro";
            this.lblPesqBairro.Size = new System.Drawing.Size(48, 18);
            this.lblPesqBairro.TabIndex = 44;
            this.lblPesqBairro.Text = "Bairro";
            // 
            // txtPesqDataNascimento
            // 
            this.txtPesqDataNascimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesqDataNascimento.Location = new System.Drawing.Point(207, 108);
            this.txtPesqDataNascimento.Name = "txtPesqDataNascimento";
            this.txtPesqDataNascimento.Size = new System.Drawing.Size(196, 24);
            this.txtPesqDataNascimento.TabIndex = 3;
            this.txtPesqDataNascimento.TextChanged += new System.EventHandler(this.txtPesqNome_TextChanged);
            // 
            // lblPesqDataNascimento
            // 
            this.lblPesqDataNascimento.AutoSize = true;
            this.lblPesqDataNascimento.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.lblPesqDataNascimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPesqDataNascimento.Location = new System.Drawing.Point(78, 114);
            this.lblPesqDataNascimento.Name = "lblPesqDataNascimento";
            this.lblPesqDataNascimento.Size = new System.Drawing.Size(123, 18);
            this.lblPesqDataNascimento.TabIndex = 42;
            this.lblPesqDataNascimento.Text = "Data Nascimento";
            // 
            // txtPesqUf
            // 
            this.txtPesqUf.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesqUf.Location = new System.Drawing.Point(1040, 78);
            this.txtPesqUf.Name = "txtPesqUf";
            this.txtPesqUf.Size = new System.Drawing.Size(163, 24);
            this.txtPesqUf.TabIndex = 10;
            this.txtPesqUf.TextChanged += new System.EventHandler(this.txtPesqNome_TextChanged);
            // 
            // lblPesqUf
            // 
            this.lblPesqUf.AutoSize = true;
            this.lblPesqUf.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.lblPesqUf.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPesqUf.Location = new System.Drawing.Point(1011, 72);
            this.lblPesqUf.Name = "lblPesqUf";
            this.lblPesqUf.Size = new System.Drawing.Size(23, 18);
            this.lblPesqUf.TabIndex = 40;
            this.lblPesqUf.Text = "Uf";
            // 
            // txtPesqNumero
            // 
            this.txtPesqNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesqNumero.Location = new System.Drawing.Point(649, 111);
            this.txtPesqNumero.Name = "txtPesqNumero";
            this.txtPesqNumero.Size = new System.Drawing.Size(269, 24);
            this.txtPesqNumero.TabIndex = 7;
            this.txtPesqNumero.TextChanged += new System.EventHandler(this.txtPesqNome_TextChanged);
            // 
            // lblPesqNumero
            // 
            this.lblPesqNumero.AutoSize = true;
            this.lblPesqNumero.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.lblPesqNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPesqNumero.Location = new System.Drawing.Point(581, 117);
            this.lblPesqNumero.Name = "lblPesqNumero";
            this.lblPesqNumero.Size = new System.Drawing.Size(62, 18);
            this.lblPesqNumero.TabIndex = 38;
            this.lblPesqNumero.Text = "Número";
            // 
            // txtPesqEmail
            // 
            this.txtPesqEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesqEmail.Location = new System.Drawing.Point(205, 147);
            this.txtPesqEmail.Name = "txtPesqEmail";
            this.txtPesqEmail.Size = new System.Drawing.Size(198, 24);
            this.txtPesqEmail.TabIndex = 4;
            this.txtPesqEmail.TextChanged += new System.EventHandler(this.txtPesqNome_TextChanged);
            // 
            // lblPesqEmail
            // 
            this.lblPesqEmail.AutoSize = true;
            this.lblPesqEmail.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.lblPesqEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPesqEmail.Location = new System.Drawing.Point(154, 153);
            this.lblPesqEmail.Name = "lblPesqEmail";
            this.lblPesqEmail.Size = new System.Drawing.Size(45, 18);
            this.lblPesqEmail.TabIndex = 36;
            this.lblPesqEmail.Text = "Email";
            // 
            // lblPesqLogradouro
            // 
            this.lblPesqLogradouro.AutoSize = true;
            this.lblPesqLogradouro.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.lblPesqLogradouro.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPesqLogradouro.Location = new System.Drawing.Point(576, 75);
            this.lblPesqLogradouro.Name = "lblPesqLogradouro";
            this.lblPesqLogradouro.Size = new System.Drawing.Size(67, 18);
            this.lblPesqLogradouro.TabIndex = 35;
            this.lblPesqLogradouro.Text = "Rua / Av.";
            // 
            // txtPesqLogradouro
            // 
            this.txtPesqLogradouro.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesqLogradouro.Location = new System.Drawing.Point(649, 72);
            this.txtPesqLogradouro.Name = "txtPesqLogradouro";
            this.txtPesqLogradouro.Size = new System.Drawing.Size(269, 24);
            this.txtPesqLogradouro.TabIndex = 6;
            this.txtPesqLogradouro.TextChanged += new System.EventHandler(this.txtPesqNome_TextChanged);
            // 
            // lblPesqMunicipio
            // 
            this.lblPesqMunicipio.AutoSize = true;
            this.lblPesqMunicipio.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.lblPesqMunicipio.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPesqMunicipio.Location = new System.Drawing.Point(963, 34);
            this.lblPesqMunicipio.Name = "lblPesqMunicipio";
            this.lblPesqMunicipio.Size = new System.Drawing.Size(71, 18);
            this.lblPesqMunicipio.TabIndex = 33;
            this.lblPesqMunicipio.Text = "Municipio";
            // 
            // lblPesqCep
            // 
            this.lblPesqCep.AutoSize = true;
            this.lblPesqCep.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.lblPesqCep.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPesqCep.Location = new System.Drawing.Point(608, 36);
            this.lblPesqCep.Name = "lblPesqCep";
            this.lblPesqCep.Size = new System.Drawing.Size(35, 18);
            this.lblPesqCep.TabIndex = 32;
            this.lblPesqCep.Text = "Cep";
            // 
            // lblPesqSexo
            // 
            this.lblPesqSexo.AutoSize = true;
            this.lblPesqSexo.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.lblPesqSexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPesqSexo.Location = new System.Drawing.Point(159, 78);
            this.lblPesqSexo.Name = "lblPesqSexo";
            this.lblPesqSexo.Size = new System.Drawing.Size(42, 18);
            this.lblPesqSexo.TabIndex = 31;
            this.lblPesqSexo.Text = "Sexo";
            // 
            // txtPesqBairro
            // 
            this.txtPesqBairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesqBairro.Location = new System.Drawing.Point(1040, 33);
            this.txtPesqBairro.Name = "txtPesqBairro";
            this.txtPesqBairro.Size = new System.Drawing.Size(163, 24);
            this.txtPesqBairro.TabIndex = 9;
            this.txtPesqBairro.TextChanged += new System.EventHandler(this.txtPesqNome_TextChanged);
            // 
            // txtPesqCep
            // 
            this.txtPesqCep.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesqCep.Location = new System.Drawing.Point(649, 33);
            this.txtPesqCep.Name = "txtPesqCep";
            this.txtPesqCep.Size = new System.Drawing.Size(269, 24);
            this.txtPesqCep.TabIndex = 5;
            this.txtPesqCep.TextChanged += new System.EventHandler(this.txtPesqNome_TextChanged);
            // 
            // txtPesqSexo
            // 
            this.txtPesqSexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesqSexo.Location = new System.Drawing.Point(207, 72);
            this.txtPesqSexo.Name = "txtPesqSexo";
            this.txtPesqSexo.Size = new System.Drawing.Size(196, 24);
            this.txtPesqSexo.TabIndex = 2;
            this.txtPesqSexo.TextChanged += new System.EventHandler(this.txtPesqNome_TextChanged);
            // 
            // lblPesqNome
            // 
            this.lblPesqNome.AutoSize = true;
            this.lblPesqNome.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.lblPesqNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPesqNome.Location = new System.Drawing.Point(152, 42);
            this.lblPesqNome.Name = "lblPesqNome";
            this.lblPesqNome.Size = new System.Drawing.Size(49, 18);
            this.lblPesqNome.TabIndex = 27;
            this.lblPesqNome.Text = "Nome";
            // 
            // txtPesqNome
            // 
            this.txtPesqNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesqNome.Location = new System.Drawing.Point(207, 36);
            this.txtPesqNome.Name = "txtPesqNome";
            this.txtPesqNome.Size = new System.Drawing.Size(196, 24);
            this.txtPesqNome.TabIndex = 1;
            this.txtPesqNome.TextChanged += new System.EventHandler(this.txtPesqNome_TextChanged);
            // 
            // dgvContatos
            // 
            this.dgvContatos.AutoGenerateColumns = false;
            this.dgvContatos.BackgroundColor = System.Drawing.Color.White;
            this.dgvContatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11});
            this.dgvContatos.DataSource = this.contatoesBindingSource;
            this.dgvContatos.Location = new System.Drawing.Point(21, 211);
            this.dgvContatos.Name = "dgvContatos";
            this.dgvContatos.Size = new System.Drawing.Size(1322, 338);
            this.dgvContatos.TabIndex = 11;
            this.dgvContatos.SelectionChanged += new System.EventHandler(this.dgvContatos_SelectionChanged);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "ID";
            this.Column1.HeaderText = "Id";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Nome";
            this.dataGridViewTextBoxColumn2.HeaderText = "NOME";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "DataNascimento";
            this.dataGridViewTextBoxColumn3.HeaderText = "DATA NASCIMENTO";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 150;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Sexo";
            this.dataGridViewTextBoxColumn4.HeaderText = "SEXO";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 50;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Email";
            this.dataGridViewTextBoxColumn5.HeaderText = "EMAIL";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 200;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Cep";
            this.dataGridViewTextBoxColumn6.HeaderText = "CEP";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 80;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Logradoouro";
            this.dataGridViewTextBoxColumn7.HeaderText = "ENDEREÇO";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 150;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Numero";
            this.dataGridViewTextBoxColumn8.HeaderText = "NUMERO";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 80;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Bairro";
            this.dataGridViewTextBoxColumn9.HeaderText = "BAIRRO";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Width = 150;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Municipio";
            this.dataGridViewTextBoxColumn10.HeaderText = "MUNICIPIO";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.Width = 150;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "Uf";
            this.dataGridViewTextBoxColumn11.HeaderText = "UF";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.Width = 50;
            // 
            // contatoesBindingSource
            // 
            this.contatoesBindingSource.DataMember = "Contatoes";
            this.contatoesBindingSource.DataSource = this.agendaDataSet;
            // 
            // agendaDataSet
            // 
            this.agendaDataSet.DataSetName = "AgendaDataSet";
            this.agendaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // agendaDataSetBindingSource
            // 
            this.agendaDataSetBindingSource.DataSource = this.agendaDataSet;
            this.agendaDataSetBindingSource.Position = 0;
            // 
            // contatoesTableAdapter
            // 
            this.contatoesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.@__MigrationHistoryTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ContatoesTableAdapter = this.contatoesTableAdapter;
            this.tableAdapterManager.UpdateOrder = Cadastro.AgendaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // textAlteraDtNascimento
            // 
            this.textAlteraDtNascimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textAlteraDtNascimento.Location = new System.Drawing.Point(147, 105);
            this.textAlteraDtNascimento.Mask = "00/00/0000";
            this.textAlteraDtNascimento.Name = "textAlteraDtNascimento";
            this.textAlteraDtNascimento.Size = new System.Drawing.Size(110, 24);
            this.textAlteraDtNascimento.TabIndex = 2;
            // 
            // mkdTexAlteraCEP
            // 
            this.mkdTexAlteraCEP.BackColor = System.Drawing.Color.White;
            this.mkdTexAlteraCEP.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mkdTexAlteraCEP.Location = new System.Drawing.Point(147, 191);
            this.mkdTexAlteraCEP.Mask = "00000-000";
            this.mkdTexAlteraCEP.Name = "mkdTexAlteraCEP";
            this.mkdTexAlteraCEP.Size = new System.Drawing.Size(87, 24);
            this.mkdTexAlteraCEP.TabIndex = 4;
            // 
            // textAlteraSexo
            // 
            this.textAlteraSexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textAlteraSexo.Location = new System.Drawing.Point(86, 96);
            this.textAlteraSexo.Name = "textAlteraSexo";
            this.textAlteraSexo.Size = new System.Drawing.Size(48, 24);
            this.textAlteraSexo.TabIndex = 32;
            this.textAlteraSexo.Visible = false;
            // 
            // textAlteraUf
            // 
            this.textAlteraUf.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textAlteraUf.Location = new System.Drawing.Point(143, 409);
            this.textAlteraUf.Name = "textAlteraUf";
            this.textAlteraUf.Size = new System.Drawing.Size(91, 24);
            this.textAlteraUf.TabIndex = 9;
            // 
            // textAlteraMunicipio
            // 
            this.textAlteraMunicipio.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textAlteraMunicipio.Location = new System.Drawing.Point(143, 369);
            this.textAlteraMunicipio.Name = "textAlteraMunicipio";
            this.textAlteraMunicipio.Size = new System.Drawing.Size(315, 24);
            this.textAlteraMunicipio.TabIndex = 8;
            // 
            // textAlteraBairro
            // 
            this.textAlteraBairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textAlteraBairro.Location = new System.Drawing.Point(143, 325);
            this.textAlteraBairro.Name = "textAlteraBairro";
            this.textAlteraBairro.Size = new System.Drawing.Size(315, 24);
            this.textAlteraBairro.TabIndex = 7;
            // 
            // textAlteraNumero
            // 
            this.textAlteraNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textAlteraNumero.Location = new System.Drawing.Point(143, 284);
            this.textAlteraNumero.Name = "textAlteraNumero";
            this.textAlteraNumero.Size = new System.Drawing.Size(91, 24);
            this.textAlteraNumero.TabIndex = 6;
            // 
            // textAlteraLogradouro
            // 
            this.textAlteraLogradouro.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textAlteraLogradouro.Location = new System.Drawing.Point(147, 236);
            this.textAlteraLogradouro.Name = "textAlteraLogradouro";
            this.textAlteraLogradouro.Size = new System.Drawing.Size(315, 24);
            this.textAlteraLogradouro.TabIndex = 5;
            // 
            // textAlteraEmail
            // 
            this.textAlteraEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textAlteraEmail.Location = new System.Drawing.Point(148, 152);
            this.textAlteraEmail.Name = "textAlteraEmail";
            this.textAlteraEmail.Size = new System.Drawing.Size(315, 24);
            this.textAlteraEmail.TabIndex = 3;
            // 
            // textAlteraNome
            // 
            this.textAlteraNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textAlteraNome.Location = new System.Drawing.Point(148, 65);
            this.textAlteraNome.Name = "textAlteraNome";
            this.textAlteraNome.Size = new System.Drawing.Size(315, 24);
            this.textAlteraNome.TabIndex = 1;
            // 
            // frmListContato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1355, 636);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmListContato";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contatos";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panelAlterar.ResumeLayout(false);
            this.panelAlterar.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBoxPesquisa.ResumeLayout(false);
            this.groupBoxPesquisa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contatoesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agendaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agendaDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource agendaDataSetBindingSource;
        private AgendaDataSet agendaDataSet;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.BindingSource contatoesBindingSource;
        private AgendaDataSetTableAdapters.ContatoesTableAdapter contatoesTableAdapter;
        private AgendaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView dgvContatos;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Panel panelAlterar;
        private System.Windows.Forms.Button btnSalva;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdoBtnAlteraFeminino;
        private System.Windows.Forms.RadioButton rdoBtnAlteraMasculino;
        private MyTextBox textAlteraUf;
        private MyTextBox textAlteraMunicipio;
        private MyTextBox textAlteraBairro;
        private MyTextBox textAlteraNumero;
        private MyTextBox textAlteraLogradouro;
        private MyTextBox textAlteraNome;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private MyMaskedTextBox mkdTexAlteraCEP;
        private MyTextBox textAlteraSexo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.TextBox txtPesqNome;
        private System.Windows.Forms.Label lblPesqNome;
        private System.Windows.Forms.GroupBox groupBoxPesquisa;
        private System.Windows.Forms.Label lblPesqMunicipio;
        private System.Windows.Forms.Label lblPesqCep;
        private System.Windows.Forms.Label lblPesqSexo;
        private System.Windows.Forms.TextBox txtPesqBairro;
        private System.Windows.Forms.TextBox txtPesqCep;
        private System.Windows.Forms.TextBox txtPesqSexo;
        private System.Windows.Forms.TextBox txtPesqDataNascimento;
        private System.Windows.Forms.Label lblPesqDataNascimento;
        private System.Windows.Forms.TextBox txtPesqUf;
        private System.Windows.Forms.Label lblPesqUf;
        private System.Windows.Forms.TextBox txtPesqNumero;
        private System.Windows.Forms.Label lblPesqNumero;
        private System.Windows.Forms.TextBox txtPesqEmail;
        private System.Windows.Forms.Label lblPesqEmail;
        private System.Windows.Forms.Label lblPesqLogradouro;
        private System.Windows.Forms.TextBox txtPesqLogradouro;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.TextBox txtPesqMunicipio;
        private System.Windows.Forms.Label lblPesqBairro;
        private System.Windows.Forms.Button btnCancelarAlteracao;
        private System.Windows.Forms.Button btnClearPesquisa;
        private MyMaskedTextBox textAlteraDtNascimento;
        private MyTextBox textAlteraEmail;
    }
}