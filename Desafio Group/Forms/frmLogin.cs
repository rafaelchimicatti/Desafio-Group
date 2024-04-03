using System;
using System.Windows.Forms;
using Desafio_Group.Forms;
using Desafio_Group.Util;

namespace Desafio_Group
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmCadastro form3 = new frmCadastro();
            form3.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string email, senha;

                email = BoxEmail.Text;
                senha = BoxSenha.Text;

                if (BancoDados.VerificarCredenciais(email, senha))
                {

                    this.Hide();

                    frmDados form2 = new frmDados();
                    form2.FormClosed += Form2_FormClosed;
                    form2.Show();
                }
                else
                {
                    MessageBox.Show("Erro ao entrar.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao verificar credenciais: " + ex.Message);
            }

        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private void buttonRecuperarSenha_Click(object sender, EventArgs e)
        {
            frmRecuperarSenha form = new frmRecuperarSenha();
            form.ShowDialog();
        }

        private void BoxSenha_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonEntrar.PerformClick();
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
