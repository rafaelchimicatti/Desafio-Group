using Desafio_Group.Util;
using System;
using System.Windows.Forms;

namespace Desafio_Group.Forms
{
    public partial class frmRecuperarSenha : Form
    {
        public frmRecuperarSenha()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string email = textBoxEmail.Text;
                if (Validacoes.ValidarEmail(email) && BancoDados.ExisteEmail(email))
                {

                    int token = BancoDados.ConsultarCodigo(email);
                    Recuperacao.EnviarEmailRecuperacao(email, token);
                    frmNovaSenha form = new frmNovaSenha(email);
                    form.ShowDialog();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("E-mail inválido.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao enviar e-mail: " + ex.Message);
            }
        }

        private void textBoxEmail_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1.PerformClick();
            }
        }
    }
}
