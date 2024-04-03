namespace Desafio_Group.Forms
{
    partial class frmAdicionarCliente
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
            this.lblAdicionarCliente = new System.Windows.Forms.Label();
            this.textNome = new System.Windows.Forms.TextBox();
            this.textEmail = new System.Windows.Forms.TextBox();
            this.labelNome = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.textTelefone = new System.Windows.Forms.TextBox();
            this.labelTelefone = new System.Windows.Forms.Label();
            this.labelDocumento = new System.Windows.Forms.Label();
            this.textCidade = new System.Windows.Forms.TextBox();
            this.labelCidade = new System.Windows.Forms.Label();
            this.textBairro = new System.Windows.Forms.TextBox();
            this.labelBairro = new System.Windows.Forms.Label();
            this.labelLogradouro = new System.Windows.Forms.Label();
            this.textLogradouro = new System.Windows.Forms.TextBox();
            this.textNumero = new System.Windows.Forms.TextBox();
            this.labelNumero = new System.Windows.Forms.Label();
            this.buttonAdicionar = new System.Windows.Forms.Button();
            this.radioButtonPF = new System.Windows.Forms.RadioButton();
            this.radioButtonPJ = new System.Windows.Forms.RadioButton();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.textBoxCEP = new System.Windows.Forms.TextBox();
            this.labelCEP = new System.Windows.Forms.Label();
            this.textDocumento = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblAdicionarCliente
            // 
            this.lblAdicionarCliente.AutoSize = true;
            this.lblAdicionarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdicionarCliente.Location = new System.Drawing.Point(20, 21);
            this.lblAdicionarCliente.Name = "lblAdicionarCliente";
            this.lblAdicionarCliente.Size = new System.Drawing.Size(280, 38);
            this.lblAdicionarCliente.TabIndex = 0;
            this.lblAdicionarCliente.Text = "Adicionar Cliente";
            // 
            // textNome
            // 
            this.textNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textNome.Location = new System.Drawing.Point(27, 87);
            this.textNome.Name = "textNome";
            this.textNome.Size = new System.Drawing.Size(542, 22);
            this.textNome.TabIndex = 1;
            // 
            // textEmail
            // 
            this.textEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textEmail.Location = new System.Drawing.Point(28, 141);
            this.textEmail.Name = "textEmail";
            this.textEmail.Size = new System.Drawing.Size(542, 22);
            this.textEmail.TabIndex = 2;
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Location = new System.Drawing.Point(25, 68);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(44, 16);
            this.labelNome.TabIndex = 3;
            this.labelNome.Text = "Nome";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(25, 122);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(45, 16);
            this.labelEmail.TabIndex = 4;
            this.labelEmail.Text = "E-mail";
            // 
            // textTelefone
            // 
            this.textTelefone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textTelefone.Location = new System.Drawing.Point(27, 340);
            this.textTelefone.Name = "textTelefone";
            this.textTelefone.Size = new System.Drawing.Size(196, 22);
            this.textTelefone.TabIndex = 8;
            // 
            // labelTelefone
            // 
            this.labelTelefone.AutoSize = true;
            this.labelTelefone.Location = new System.Drawing.Point(26, 321);
            this.labelTelefone.Name = "labelTelefone";
            this.labelTelefone.Size = new System.Drawing.Size(61, 16);
            this.labelTelefone.TabIndex = 6;
            this.labelTelefone.Text = "Telefone";
            // 
            // labelDocumento
            // 
            this.labelDocumento.AutoSize = true;
            this.labelDocumento.Location = new System.Drawing.Point(226, 321);
            this.labelDocumento.Name = "labelDocumento";
            this.labelDocumento.Size = new System.Drawing.Size(76, 16);
            this.labelDocumento.TabIndex = 8;
            this.labelDocumento.Text = "Documento";
            // 
            // textCidade
            // 
            this.textCidade.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textCidade.Location = new System.Drawing.Point(27, 232);
            this.textCidade.Name = "textCidade";
            this.textCidade.Size = new System.Drawing.Size(244, 22);
            this.textCidade.TabIndex = 4;
            // 
            // labelCidade
            // 
            this.labelCidade.AutoSize = true;
            this.labelCidade.Location = new System.Drawing.Point(24, 214);
            this.labelCidade.Name = "labelCidade";
            this.labelCidade.Size = new System.Drawing.Size(51, 16);
            this.labelCidade.TabIndex = 16;
            this.labelCidade.Text = "Cidade";
            // 
            // textBairro
            // 
            this.textBairro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBairro.Location = new System.Drawing.Point(277, 232);
            this.textBairro.Name = "textBairro";
            this.textBairro.Size = new System.Drawing.Size(293, 22);
            this.textBairro.TabIndex = 5;
            // 
            // labelBairro
            // 
            this.labelBairro.AutoSize = true;
            this.labelBairro.Location = new System.Drawing.Point(274, 213);
            this.labelBairro.Name = "labelBairro";
            this.labelBairro.Size = new System.Drawing.Size(43, 16);
            this.labelBairro.TabIndex = 18;
            this.labelBairro.Text = "Bairro";
            // 
            // labelLogradouro
            // 
            this.labelLogradouro.AutoSize = true;
            this.labelLogradouro.Location = new System.Drawing.Point(24, 270);
            this.labelLogradouro.Name = "labelLogradouro";
            this.labelLogradouro.Size = new System.Drawing.Size(77, 16);
            this.labelLogradouro.TabIndex = 19;
            this.labelLogradouro.Text = "Logradouro";
            // 
            // textLogradouro
            // 
            this.textLogradouro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textLogradouro.Location = new System.Drawing.Point(27, 289);
            this.textLogradouro.Name = "textLogradouro";
            this.textLogradouro.Size = new System.Drawing.Size(465, 22);
            this.textLogradouro.TabIndex = 6;
            // 
            // textNumero
            // 
            this.textNumero.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textNumero.Location = new System.Drawing.Point(499, 289);
            this.textNumero.Name = "textNumero";
            this.textNumero.Size = new System.Drawing.Size(71, 22);
            this.textNumero.TabIndex = 7;
            // 
            // labelNumero
            // 
            this.labelNumero.AutoSize = true;
            this.labelNumero.Location = new System.Drawing.Point(496, 270);
            this.labelNumero.Name = "labelNumero";
            this.labelNumero.Size = new System.Drawing.Size(55, 16);
            this.labelNumero.TabIndex = 22;
            this.labelNumero.Text = "Número";
            // 
            // buttonAdicionar
            // 
            this.buttonAdicionar.Location = new System.Drawing.Point(480, 393);
            this.buttonAdicionar.Name = "buttonAdicionar";
            this.buttonAdicionar.Size = new System.Drawing.Size(102, 27);
            this.buttonAdicionar.TabIndex = 12;
            this.buttonAdicionar.Text = "Adicionar";
            this.buttonAdicionar.UseVisualStyleBackColor = true;
            this.buttonAdicionar.Click += new System.EventHandler(this.buttonAdicionar_Click);
            // 
            // radioButtonPF
            // 
            this.radioButtonPF.AutoSize = true;
            this.radioButtonPF.Location = new System.Drawing.Point(229, 368);
            this.radioButtonPF.Name = "radioButtonPF";
            this.radioButtonPF.Size = new System.Drawing.Size(114, 20);
            this.radioButtonPF.TabIndex = 10;
            this.radioButtonPF.TabStop = true;
            this.radioButtonPF.Text = "Pessoa Física";
            this.radioButtonPF.UseVisualStyleBackColor = true;
            // 
            // radioButtonPJ
            // 
            this.radioButtonPJ.AutoSize = true;
            this.radioButtonPJ.Location = new System.Drawing.Point(349, 368);
            this.radioButtonPJ.Name = "radioButtonPJ";
            this.radioButtonPJ.Size = new System.Drawing.Size(125, 20);
            this.radioButtonPJ.TabIndex = 11;
            this.radioButtonPJ.TabStop = true;
            this.radioButtonPJ.Text = "Pessoa Jurídica";
            this.radioButtonPJ.UseVisualStyleBackColor = true;
            // 
            // textBoxCEP
            // 
            this.textBoxCEP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxCEP.Location = new System.Drawing.Point(27, 189);
            this.textBoxCEP.Name = "textBoxCEP";
            this.textBoxCEP.Size = new System.Drawing.Size(139, 22);
            this.textBoxCEP.TabIndex = 3;
            this.textBoxCEP.TextChanged += new System.EventHandler(this.textBoxCEP_TextChanged);
            // 
            // labelCEP
            // 
            this.labelCEP.AutoSize = true;
            this.labelCEP.Location = new System.Drawing.Point(24, 170);
            this.labelCEP.Name = "labelCEP";
            this.labelCEP.Size = new System.Drawing.Size(34, 16);
            this.labelCEP.TabIndex = 27;
            this.labelCEP.Text = "CEP";
            // 
            // textDocumento
            // 
            this.textDocumento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textDocumento.Location = new System.Drawing.Point(229, 340);
            this.textDocumento.Name = "textDocumento";
            this.textDocumento.Size = new System.Drawing.Size(340, 22);
            this.textDocumento.TabIndex = 9;
            this.textDocumento.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textDocumento_KeyDown);
            // 
            // frmAdicionarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 437);
            this.Controls.Add(this.labelCEP);
            this.Controls.Add(this.textBoxCEP);
            this.Controls.Add(this.radioButtonPJ);
            this.Controls.Add(this.radioButtonPF);
            this.Controls.Add(this.buttonAdicionar);
            this.Controls.Add(this.labelNumero);
            this.Controls.Add(this.textNumero);
            this.Controls.Add(this.textLogradouro);
            this.Controls.Add(this.labelLogradouro);
            this.Controls.Add(this.labelBairro);
            this.Controls.Add(this.textBairro);
            this.Controls.Add(this.labelCidade);
            this.Controls.Add(this.textCidade);
            this.Controls.Add(this.labelDocumento);
            this.Controls.Add(this.textDocumento);
            this.Controls.Add(this.labelTelefone);
            this.Controls.Add(this.textTelefone);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.labelNome);
            this.Controls.Add(this.textEmail);
            this.Controls.Add(this.textNome);
            this.Controls.Add(this.lblAdicionarCliente);
            this.MinimizeBox = false;
            this.Name = "frmAdicionarCliente";
            this.ShowIcon = false;
            this.Text = "Adicionar cliente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAdicionarCliente;
        private System.Windows.Forms.TextBox textNome;
        private System.Windows.Forms.TextBox textEmail;
        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.TextBox textTelefone;
        private System.Windows.Forms.Label labelTelefone;
        private System.Windows.Forms.Label labelDocumento;
        private System.Windows.Forms.TextBox textCidade;
        private System.Windows.Forms.Label labelCidade;
        private System.Windows.Forms.TextBox textBairro;
        private System.Windows.Forms.Label labelBairro;
        private System.Windows.Forms.Label labelLogradouro;
        private System.Windows.Forms.TextBox textLogradouro;
        private System.Windows.Forms.TextBox textNumero;
        private System.Windows.Forms.Label labelNumero;
        private System.Windows.Forms.Button buttonAdicionar;
        private System.Windows.Forms.RadioButton radioButtonPF;
        private System.Windows.Forms.RadioButton radioButtonPJ;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox textBoxCEP;
        private System.Windows.Forms.Label labelCEP;
        private System.Windows.Forms.TextBox textDocumento;
    }
}