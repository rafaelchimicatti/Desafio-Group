namespace Desafio_Group.Forms
{
    partial class frmCadastro
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
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxSenha = new System.Windows.Forms.TextBox();
            this.textBoxConfirmarSenha = new System.Windows.Forms.TextBox();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelSenha = new System.Windows.Forms.Label();
            this.labelConfirmarSenha = new System.Windows.Forms.Label();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxEmail.Location = new System.Drawing.Point(8, 31);
            this.textBoxEmail.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(482, 22);
            this.textBoxEmail.TabIndex = 0;
            // 
            // textBoxSenha
            // 
            this.textBoxSenha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxSenha.Location = new System.Drawing.Point(8, 90);
            this.textBoxSenha.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxSenha.Name = "textBoxSenha";
            this.textBoxSenha.Size = new System.Drawing.Size(482, 22);
            this.textBoxSenha.TabIndex = 1;
            this.textBoxSenha.UseSystemPasswordChar = true;
            // 
            // textBoxConfirmarSenha
            // 
            this.textBoxConfirmarSenha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxConfirmarSenha.Location = new System.Drawing.Point(8, 145);
            this.textBoxConfirmarSenha.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxConfirmarSenha.Name = "textBoxConfirmarSenha";
            this.textBoxConfirmarSenha.Size = new System.Drawing.Size(482, 22);
            this.textBoxConfirmarSenha.TabIndex = 2;
            this.textBoxConfirmarSenha.UseSystemPasswordChar = true;
            this.textBoxConfirmarSenha.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxConfirmarSenha_KeyDown);
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(12, 11);
            this.labelEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(45, 16);
            this.labelEmail.TabIndex = 3;
            this.labelEmail.Text = "E-mail";
            // 
            // labelSenha
            // 
            this.labelSenha.AutoSize = true;
            this.labelSenha.Location = new System.Drawing.Point(12, 70);
            this.labelSenha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSenha.Name = "labelSenha";
            this.labelSenha.Size = new System.Drawing.Size(46, 16);
            this.labelSenha.TabIndex = 4;
            this.labelSenha.Text = "Senha";
            // 
            // labelConfirmarSenha
            // 
            this.labelConfirmarSenha.AutoSize = true;
            this.labelConfirmarSenha.Location = new System.Drawing.Point(12, 125);
            this.labelConfirmarSenha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelConfirmarSenha.Name = "labelConfirmarSenha";
            this.labelConfirmarSenha.Size = new System.Drawing.Size(106, 16);
            this.labelConfirmarSenha.TabIndex = 5;
            this.labelConfirmarSenha.Text = "Confirmar Senha";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(388, 181);
            this.btnCadastrar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(100, 28);
            this.btnCadastrar.TabIndex = 6;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // frmCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(504, 224);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.labelConfirmarSenha);
            this.Controls.Add(this.labelSenha);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.textBoxConfirmarSenha);
            this.Controls.Add(this.textBoxSenha);
            this.Controls.Add(this.textBoxEmail);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCadastro";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cadastrar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxSenha;
        private System.Windows.Forms.TextBox textBoxConfirmarSenha;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelSenha;
        private System.Windows.Forms.Label labelConfirmarSenha;
        private System.Windows.Forms.Button btnCadastrar;
    }
}