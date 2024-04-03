using Desafio_Group.Util;
using System;
using System.Windows.Forms;

namespace Desafio_Group.Forms
{
    public partial class frmCadastro : Form
    {
        public frmCadastro()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            string email, senha, confirmarSenha;

            email = textBoxEmail.Text;
            senha = textBoxSenha.Text;
            confirmarSenha = textBoxSenha.Text;

            if(senha == confirmarSenha) {

            try {
                    if (Validacoes.ValidarEmail(email) && !BancoDados.ExisteEmail(email)) { 
                    BancoDados.AdicionarUsuario(email, senha);
                    this.Hide(); }
                    else
                    {
                        if (Validacoes.ValidarEmail(email))
                            MessageBox.Show("E-mail já cadastrado");
                        else
                        {
                            MessageBox.Show("E-mail inválido.");
                        }
                    }
                }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar: " + ex.Message);
            } 
            }
        }

        private void textBoxConfirmarSenha_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnCadastrar.PerformClick();
            }
        }
    }
}
