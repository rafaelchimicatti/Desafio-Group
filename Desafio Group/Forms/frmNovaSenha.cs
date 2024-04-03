using Desafio_Group.Util;
using System;
using System.Windows.Forms;

namespace Desafio_Group.Forms
{
    public partial class frmNovaSenha : Form
    {
        private string _email;
        public frmNovaSenha(string email)
        {
            InitializeComponent();
            _email = email;
        }

        private void buttonConfirmar_Click(object sender, EventArgs e)
        {
            try
            {
                string codigo = textBoxCodigo.Text;
                string senha = textBoxSenha.Text;
                string confirmaSenha = textBoxConfirmaSenha.Text;
                string email = this._email;
                bool mudou = false;

                if (senha == confirmaSenha)
                {
                    mudou = BancoDados.AtualizaSenha(email, senha, codigo);  
                }
                else
                {
                    MessageBox.Show("As senhas devem ser iguais.");
                }
                if (mudou)
                {
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao mudar senha: " + ex.Message);
            }
        }

        private void textBoxConfirmaSenha_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonConfirmar.PerformClick();
            }
        }
    }
}
