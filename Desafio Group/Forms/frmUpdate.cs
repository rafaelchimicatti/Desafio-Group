using Desafio_Group.Util;
using System;
using System.Windows.Forms;

namespace Desafio_Group.Forms
{
    public partial class frmUpdate : Form
    {
        private string _tipo, _documento;

        private void buttonAtualizar_Click(object sender, EventArgs e)
        {
            try
            {
                string novoDado = textBoxNovoDado.Text;
                BancoDados.AtualizarDado(_documento, _tipo, novoDado);
                this.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Erro ao atualizar dado: " + ex.Message);
            }
        }

        private void textBoxNovoDado_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonAtualizar.PerformClick();
            }
        }

        public frmUpdate(string tipo, string documento)
        {
            _tipo = tipo;
            _documento = documento;
            InitializeComponent();
            this.Text += " " + _tipo;
        }




    }
}
