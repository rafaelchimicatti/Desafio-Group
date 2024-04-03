using Desafio_Group.Util;
using Entities;
using System;
using System.Windows.Forms;
using System.ComponentModel.DataAnnotations;

namespace Desafio_Group.Forms
{
    public partial class frmAdicionarCliente : Form
    {
        public frmAdicionarCliente()
        {
            InitializeComponent();
        }

        private void buttonAdicionar_Click(object sender, EventArgs e)
        {
            try
            {
                string nome, documento, email, telefone, cidade, bairro, rua;
                char tipo;
                int numero;

                cidade = textCidade.Text;
                bairro = textBairro.Text;
                rua = textLogradouro.Text;
                numero = int.Parse(textNumero.Text);

                Endereco address = new Endereco(cidade, bairro, rua, numero);

                var contextoEndereco = new ValidationContext(address);
                Validator.ValidateObject(address, contextoEndereco, true);

                nome = textNome.Text;
                documento = textDocumento.Text;
                email = textEmail.Text;
                telefone = textTelefone.Text;

                if (radioButtonPJ.Checked) tipo = 'J';
                else tipo = 'F';

                Cliente novoCliente = new Cliente(nome, tipo, documento, email, telefone, address);

                var contexto = new ValidationContext(novoCliente);
                Validator.ValidateObject(novoCliente, contexto, true);

                if (novoCliente.Tipo == 'F')
                {
                    if (!Validacoes.ValidarCPF(novoCliente.Documento))
                    {
                        MessageBox.Show("CPF inválido.");
                        return;
                    };
                }

                if (novoCliente.Tipo == 'J')
                {
                    if (!Validacoes.ValidarCNPJ(novoCliente.Documento))
                    {
                        MessageBox.Show("CNPJ inválido.");
                        return;
                    };
                }

                BancoDados.AdicionarCliente(novoCliente);
            }

            catch (Exception ex)
            {
                MessageBox.Show("Erro ao adicionar cliente: " + ex.Message);
            }

            this.Close();

            


        }

        private void textBoxCEP_TextChanged(object sender, EventArgs e)
        {
            try {
            string cep = textBoxCEP.Text;

            if(cep.Length == 8)
            {
                    Endereco address = AddressInfo.APIEndereco(cep);
                    if (address != null)
                    {
                        textCidade.Text = address.Cidade;
                        textBairro.Text = address.Bairro;
                        textLogradouro.Text = address.Rua;
                    }
                    else
                    {
                        MessageBox.Show("CEP inválido.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar endereço: " + ex.Message);
            }
        }

        private void textDocumento_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonAdicionar.PerformClick();
            }
        }
    }
}
