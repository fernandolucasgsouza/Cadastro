namespace Cadastro
{
    partial class frmCadGrupo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadGrupo));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSair = new System.Windows.Forms.Button();
            this.tabPageContdadosPessoais = new System.Windows.Forms.TabControl();
            this.tabPageDadosGrupo = new System.Windows.Forms.TabPage();
            this.lblNomeUser = new System.Windows.Forms.Label();
            this.textNomeUser = new Cadastro.MyTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabComentarios = new System.Windows.Forms.TabPage();
            this.btnAdcionar = new System.Windows.Forms.Button();
            this.btnAdiciona = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.tabPageContdadosPessoais.SuspendLayout();
            this.tabPageDadosGrupo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabComentarios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.panel1.Controls.Add(this.btnSair);
            this.panel1.Controls.Add(this.tabPageContdadosPessoais);
            this.panel1.Controls.Add(this.btnCancelar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(648, 494);
            this.panel1.TabIndex = 21;
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnSair.Location = new System.Drawing.Point(472, 432);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(130, 50);
            this.btnSair.TabIndex = 15;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // tabPageContdadosPessoais
            // 
            this.tabPageContdadosPessoais.Controls.Add(this.tabPageDadosGrupo);
            this.tabPageContdadosPessoais.Controls.Add(this.tabComentarios);
            this.tabPageContdadosPessoais.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPageContdadosPessoais.Location = new System.Drawing.Point(27, 25);
            this.tabPageContdadosPessoais.Name = "tabPageContdadosPessoais";
            this.tabPageContdadosPessoais.SelectedIndex = 0;
            this.tabPageContdadosPessoais.Size = new System.Drawing.Size(593, 390);
            this.tabPageContdadosPessoais.TabIndex = 0;
            // 
            // tabPageDadosGrupo
            // 
            this.tabPageDadosGrupo.Controls.Add(this.lblNomeUser);
            this.tabPageDadosGrupo.Controls.Add(this.textNomeUser);
            this.tabPageDadosGrupo.Controls.Add(this.pictureBox1);
            this.tabPageDadosGrupo.ForeColor = System.Drawing.Color.Navy;
            this.tabPageDadosGrupo.Location = new System.Drawing.Point(4, 25);
            this.tabPageDadosGrupo.Name = "tabPageDadosGrupo";
            this.tabPageDadosGrupo.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDadosGrupo.Size = new System.Drawing.Size(585, 361);
            this.tabPageDadosGrupo.TabIndex = 0;
            this.tabPageDadosGrupo.Text = "Dados do Grupo";
            this.tabPageDadosGrupo.UseVisualStyleBackColor = true;
            // 
            // lblNomeUser
            // 
            this.lblNomeUser.AutoSize = true;
            this.lblNomeUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeUser.ForeColor = System.Drawing.Color.Navy;
            this.lblNomeUser.Location = new System.Drawing.Point(46, 102);
            this.lblNomeUser.Name = "lblNomeUser";
            this.lblNomeUser.Size = new System.Drawing.Size(116, 18);
            this.lblNomeUser.TabIndex = 0;
            this.lblNomeUser.Text = "Nome do Grupo";
            // 
            // textNomeUser
            // 
            this.textNomeUser.BackColor = System.Drawing.Color.White;
            this.textNomeUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textNomeUser.Location = new System.Drawing.Point(168, 102);
            this.textNomeUser.Name = "textNomeUser";
            this.textNomeUser.Size = new System.Drawing.Size(291, 24);
            this.textNomeUser.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(579, 355);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // tabComentarios
            // 
            this.tabComentarios.Controls.Add(this.btnAdcionar);
            this.tabComentarios.Controls.Add(this.btnAdiciona);
            this.tabComentarios.Controls.Add(this.pictureBox2);
            this.tabComentarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabComentarios.ForeColor = System.Drawing.Color.Navy;
            this.tabComentarios.Location = new System.Drawing.Point(4, 25);
            this.tabComentarios.Name = "tabComentarios";
            this.tabComentarios.Padding = new System.Windows.Forms.Padding(3);
            this.tabComentarios.Size = new System.Drawing.Size(585, 361);
            this.tabComentarios.TabIndex = 1;
            this.tabComentarios.Text = "Comentários";
            this.tabComentarios.UseVisualStyleBackColor = true;
            // 
            // btnAdcionar
            // 
            this.btnAdcionar.BackColor = System.Drawing.Color.SteelBlue;
            this.btnAdcionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdcionar.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnAdcionar.Location = new System.Drawing.Point(440, 291);
            this.btnAdcionar.Name = "btnAdcionar";
            this.btnAdcionar.Size = new System.Drawing.Size(130, 50);
            this.btnAdcionar.TabIndex = 15;
            this.btnAdcionar.Text = "Salvar";
            this.btnAdcionar.UseVisualStyleBackColor = false;
            // 
            // btnAdiciona
            // 
            this.btnAdiciona.BackColor = System.Drawing.Color.SteelBlue;
            this.btnAdiciona.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdiciona.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnAdiciona.Location = new System.Drawing.Point(851, 477);
            this.btnAdiciona.Name = "btnAdiciona";
            this.btnAdiciona.Size = new System.Drawing.Size(130, 50);
            this.btnAdiciona.TabIndex = 14;
            this.btnAdiciona.Text = "Adcionar";
            this.btnAdiciona.UseVisualStyleBackColor = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(3, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(579, 355);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.IndianRed;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnCancelar.Location = new System.Drawing.Point(308, 432);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(130, 50);
            this.btnCancelar.TabIndex = 16;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // TCadGrupo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 494);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TCadGrupo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Novo Grupo";
            this.panel1.ResumeLayout(false);
            this.tabPageContdadosPessoais.ResumeLayout(false);
            this.tabPageDadosGrupo.ResumeLayout(false);
            this.tabPageDadosGrupo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabComentarios.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.TabControl tabPageContdadosPessoais;
        private System.Windows.Forms.TabPage tabPageDadosGrupo;
        private System.Windows.Forms.Label lblNomeUser;
        private MyTextBox textNomeUser;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabPage tabComentarios;
        private System.Windows.Forms.Button btnAdcionar;
        private System.Windows.Forms.Button btnAdiciona;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnCancelar;
    }
}