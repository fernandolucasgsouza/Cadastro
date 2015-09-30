namespace Cadastro
{
    partial class frmCadUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadUsuario));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gBoxAtivo = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rbtNao = new System.Windows.Forms.RadioButton();
            this.rbtSim = new System.Windows.Forms.RadioButton();
            this.textPerfilUser = new Cadastro.MyTextBox();
            this.lblNomeUser = new System.Windows.Forms.Label();
            this.lblPerfilUser = new System.Windows.Forms.Label();
            this.textLoginUser = new Cadastro.MyTextBox();
            this.textSenhaUser = new Cadastro.MyTextBox();
            this.lblLoginUser = new System.Windows.Forms.Label();
            this.lblSenhaUser = new System.Windows.Forms.Label();
            this.textNomeUser = new Cadastro.MyTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnAdcionar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.gBoxAtivo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btnAdcionar);
            this.panel1.Controls.Add(this.btnSair);
            this.panel1.Controls.Add(this.btnCancelar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(664, 532);
            this.panel1.TabIndex = 20;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.gBoxAtivo);
            this.panel2.Controls.Add(this.textPerfilUser);
            this.panel2.Controls.Add(this.lblNomeUser);
            this.panel2.Controls.Add(this.lblPerfilUser);
            this.panel2.Controls.Add(this.textLoginUser);
            this.panel2.Controls.Add(this.textSenhaUser);
            this.panel2.Controls.Add(this.lblLoginUser);
            this.panel2.Controls.Add(this.lblSenhaUser);
            this.panel2.Controls.Add(this.textNomeUser);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(640, 448);
            this.panel2.TabIndex = 20;
            // 
            // gBoxAtivo
            // 
            this.gBoxAtivo.Controls.Add(this.label1);
            this.gBoxAtivo.Controls.Add(this.rbtNao);
            this.gBoxAtivo.Controls.Add(this.rbtSim);
            this.gBoxAtivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBoxAtivo.ForeColor = System.Drawing.Color.Navy;
            this.gBoxAtivo.Location = new System.Drawing.Point(432, 84);
            this.gBoxAtivo.Name = "gBoxAtivo";
            this.gBoxAtivo.Size = new System.Drawing.Size(177, 127);
            this.gBoxAtivo.TabIndex = 5;
            this.gBoxAtivo.TabStop = false;
            this.gBoxAtivo.Text = "Situação";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(9, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Deseja Ativar o Usuário?";
            // 
            // rbtNao
            // 
            this.rbtNao.AutoSize = true;
            this.rbtNao.Location = new System.Drawing.Point(62, 89);
            this.rbtNao.Name = "rbtNao";
            this.rbtNao.Size = new System.Drawing.Size(54, 22);
            this.rbtNao.TabIndex = 7;
            this.rbtNao.TabStop = true;
            this.rbtNao.Text = "Não";
            this.rbtNao.UseVisualStyleBackColor = true;
            this.rbtNao.CheckedChanged += new System.EventHandler(this.rbtNao_CheckedChanged);
            // 
            // rbtSim
            // 
            this.rbtSim.AutoSize = true;
            this.rbtSim.Location = new System.Drawing.Point(62, 61);
            this.rbtSim.Name = "rbtSim";
            this.rbtSim.Size = new System.Drawing.Size(52, 22);
            this.rbtSim.TabIndex = 6;
            this.rbtSim.TabStop = true;
            this.rbtSim.Text = "Sim";
            this.rbtSim.UseVisualStyleBackColor = true;
            this.rbtSim.CheckedChanged += new System.EventHandler(this.rbtSim_CheckedChanged);
            // 
            // textPerfilUser
            // 
            this.textPerfilUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPerfilUser.Location = new System.Drawing.Point(88, 245);
            this.textPerfilUser.Name = "textPerfilUser";
            this.textPerfilUser.Size = new System.Drawing.Size(272, 24);
            this.textPerfilUser.TabIndex = 4;
            // 
            // lblNomeUser
            // 
            this.lblNomeUser.AutoSize = true;
            this.lblNomeUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeUser.ForeColor = System.Drawing.Color.Navy;
            this.lblNomeUser.Location = new System.Drawing.Point(33, 84);
            this.lblNomeUser.Name = "lblNomeUser";
            this.lblNomeUser.Size = new System.Drawing.Size(49, 18);
            this.lblNomeUser.TabIndex = 14;
            this.lblNomeUser.Text = "Nome";
            // 
            // lblPerfilUser
            // 
            this.lblPerfilUser.AutoSize = true;
            this.lblPerfilUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPerfilUser.ForeColor = System.Drawing.Color.Navy;
            this.lblPerfilUser.Location = new System.Drawing.Point(38, 251);
            this.lblPerfilUser.Name = "lblPerfilUser";
            this.lblPerfilUser.Size = new System.Drawing.Size(41, 18);
            this.lblPerfilUser.TabIndex = 16;
            this.lblPerfilUser.Text = "Perfil";
            // 
            // textLoginUser
            // 
            this.textLoginUser.BackColor = System.Drawing.Color.White;
            this.textLoginUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textLoginUser.Location = new System.Drawing.Point(88, 127);
            this.textLoginUser.Name = "textLoginUser";
            this.textLoginUser.Size = new System.Drawing.Size(272, 24);
            this.textLoginUser.TabIndex = 2;
            // 
            // textSenhaUser
            // 
            this.textSenhaUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textSenhaUser.Location = new System.Drawing.Point(88, 184);
            this.textSenhaUser.Name = "textSenhaUser";
            this.textSenhaUser.PasswordChar = '•';
            this.textSenhaUser.Size = new System.Drawing.Size(272, 24);
            this.textSenhaUser.TabIndex = 3;
            // 
            // lblLoginUser
            // 
            this.lblLoginUser.AutoSize = true;
            this.lblLoginUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoginUser.ForeColor = System.Drawing.Color.Navy;
            this.lblLoginUser.Location = new System.Drawing.Point(38, 133);
            this.lblLoginUser.Name = "lblLoginUser";
            this.lblLoginUser.Size = new System.Drawing.Size(44, 18);
            this.lblLoginUser.TabIndex = 0;
            this.lblLoginUser.Text = "Login";
            // 
            // lblSenhaUser
            // 
            this.lblSenhaUser.AutoSize = true;
            this.lblSenhaUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenhaUser.ForeColor = System.Drawing.Color.Navy;
            this.lblSenhaUser.Location = new System.Drawing.Point(32, 190);
            this.lblSenhaUser.Name = "lblSenhaUser";
            this.lblSenhaUser.Size = new System.Drawing.Size(50, 18);
            this.lblSenhaUser.TabIndex = 1;
            this.lblSenhaUser.Text = "Senha";
            // 
            // textNomeUser
            // 
            this.textNomeUser.BackColor = System.Drawing.Color.White;
            this.textNomeUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textNomeUser.Location = new System.Drawing.Point(88, 78);
            this.textNomeUser.Name = "textNomeUser";
            this.textNomeUser.Size = new System.Drawing.Size(272, 24);
            this.textNomeUser.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(640, 448);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // btnAdcionar
            // 
            this.btnAdcionar.BackColor = System.Drawing.Color.SteelBlue;
            this.btnAdcionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdcionar.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnAdcionar.Image = ((System.Drawing.Image)(resources.GetObject("btnAdcionar.Image")));
            this.btnAdcionar.Location = new System.Drawing.Point(213, 470);
            this.btnAdcionar.Name = "btnAdcionar";
            this.btnAdcionar.Size = new System.Drawing.Size(130, 50);
            this.btnAdcionar.TabIndex = 8;
            this.toolTip1.SetToolTip(this.btnAdcionar, "Salvar");
            this.btnAdcionar.UseVisualStyleBackColor = false;
            this.btnAdcionar.Click += new System.EventHandler(this.btnAdcionar_Click);
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.Location = new System.Drawing.Point(522, 470);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(130, 50);
            this.btnSair.TabIndex = 10;
            this.toolTip1.SetToolTip(this.btnSair, "Sair da Tela de Cadastro");
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.IndianRed;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.Location = new System.Drawing.Point(372, 470);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(130, 50);
            this.btnCancelar.TabIndex = 9;
            this.toolTip1.SetToolTip(this.btnCancelar, "Cancelar");
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // frmCadUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 532);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCadUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Novo Usuário";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.gBoxAtivo.ResumeLayout(false);
            this.gBoxAtivo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label lblLoginUser;
        private MyTextBox textSenhaUser;
        private System.Windows.Forms.Label lblSenhaUser;
        private MyTextBox textLoginUser;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAdcionar;
        private System.Windows.Forms.Label lblNomeUser;
        private MyTextBox textNomeUser;
        private MyTextBox textPerfilUser;
        private System.Windows.Forms.Label lblPerfilUser;
        private System.Windows.Forms.GroupBox gBoxAtivo;
        private System.Windows.Forms.RadioButton rbtNao;
        private System.Windows.Forms.RadioButton rbtSim;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}