namespace Desafio_Group
{
    partial class frmLogin
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.BoxEmail = new System.Windows.Forms.TextBox();
            this.BoxSenha = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonEntrar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonCadastrar = new System.Windows.Forms.Button();
            this.buttonRecuperarSenha = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BoxEmail
            // 
            this.BoxEmail.AcceptsReturn = true;
            this.BoxEmail.AcceptsTab = true;
            this.BoxEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BoxEmail.Location = new System.Drawing.Point(12, 281);
            this.BoxEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BoxEmail.Name = "BoxEmail";
            this.BoxEmail.Size = new System.Drawing.Size(510, 22);
            this.BoxEmail.TabIndex = 0;
            // 
            // BoxSenha
            // 
            this.BoxSenha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BoxSenha.Location = new System.Drawing.Point(12, 345);
            this.BoxSenha.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BoxSenha.Name = "BoxSenha";
            this.BoxSenha.PasswordChar = '*';
            this.BoxSenha.Size = new System.Drawing.Size(510, 22);
            this.BoxSenha.TabIndex = 1;
            this.BoxSenha.UseSystemPasswordChar = true;
            this.BoxSenha.KeyDown += new System.Windows.Forms.KeyEventHandler(this.BoxSenha_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 308);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "E-mail";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 372);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Senha";
            // 
            // buttonEntrar
            // 
            this.buttonEntrar.ForeColor = System.Drawing.Color.Black;
            this.buttonEntrar.Location = new System.Drawing.Point(428, 412);
            this.buttonEntrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonEntrar.Name = "buttonEntrar";
            this.buttonEntrar.Size = new System.Drawing.Size(93, 34);
            this.buttonEntrar.TabIndex = 4;
            this.buttonEntrar.Text = "Entrar";
            this.buttonEntrar.UseVisualStyleBackColor = true;
            this.buttonEntrar.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::Desafio_Group.Properties.Resources.group_software_associados;
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(509, 233);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // buttonCadastrar
            // 
            this.buttonCadastrar.Location = new System.Drawing.Point(320, 412);
            this.buttonCadastrar.Margin = new System.Windows.Forms.Padding(4);
            this.buttonCadastrar.Name = "buttonCadastrar";
            this.buttonCadastrar.Size = new System.Drawing.Size(101, 34);
            this.buttonCadastrar.TabIndex = 6;
            this.buttonCadastrar.Text = "Cadastre-se";
            this.buttonCadastrar.UseVisualStyleBackColor = true;
            this.buttonCadastrar.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonRecuperarSenha
            // 
            this.buttonRecuperarSenha.Location = new System.Drawing.Point(12, 412);
            this.buttonRecuperarSenha.Name = "buttonRecuperarSenha";
            this.buttonRecuperarSenha.Size = new System.Drawing.Size(158, 32);
            this.buttonRecuperarSenha.TabIndex = 7;
            this.buttonRecuperarSenha.Text = "Recuperar senha";
            this.buttonRecuperarSenha.UseVisualStyleBackColor = true;
            this.buttonRecuperarSenha.Click += new System.EventHandler(this.buttonRecuperarSenha_Click);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 460);
            this.Controls.Add(this.buttonRecuperarSenha);
            this.Controls.Add(this.buttonCadastrar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonEntrar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BoxSenha);
            this.Controls.Add(this.BoxEmail);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLogin";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox BoxEmail;
        private System.Windows.Forms.TextBox BoxSenha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonEntrar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonCadastrar;
        private System.Windows.Forms.Button buttonRecuperarSenha;
    }
}

