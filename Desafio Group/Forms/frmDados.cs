using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Desafio_Group.Util;
using Entities;
using System.Linq;

namespace Desafio_Group.Forms
{
    public partial class frmDados : Form
    {
        public List<Cliente> lista = BancoDados.AtualizarLinq();
        public frmDados()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string pesquisa = textBoxPesquisar.Text;

                if (pesquisa == "")
                {
                    dataGridView1.DataSource = lista;
                    return;
                }

                IEnumerable<Cliente> query =
                    from Cliente in lista
                    where Cliente.Documento == pesquisa || Cliente.Nome == pesquisa
                    select Cliente;

                List<Cliente> resultado = query.ToList();

                /*foreach (Cliente cliente in lista)
                {
                    if (cliente.Documento == pesquisa || cliente.Nome == pesquisa)
                    {
                        resultado.Add(cliente);
                    }
                }*/

                dataGridView1.DataSource = resultado;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao pesquisar: " + ex.Message);
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            try
            {
                Atualizar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao atualizar banco de dados: " + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmAdicionarCliente form = new frmAdicionarCliente();
            form.FormClosed += formularioEnvio_FormClosed;
            form.ShowDialog();
        }

        private void Atualizar()
        {
            try
            {
                lista = BancoDados.AtualizarLinq();
                dataGridView1.DataSource = lista;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao atualizar banco: " + ex.Message);
            }
        }

        private void formularioEnvio_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                Atualizar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao atualizar banco de dados: " + ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmLogin form = new frmLogin();
            this.Hide();
            form.Show();
        }

        private void textBoxPesquisar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1.PerformClick();
            }
        }

        private void buttonRemover_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                    string documento = selectedRow.Cells["Documento"].Value.ToString();

                    BancoDados.Remover(documento);

                    Atualizar();


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao remover: " + ex.Message);
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0) { 

            DataGridViewColumnHeaderCell headerCell = dataGridView1.Columns[e.ColumnIndex].HeaderCell;
            string tipo = headerCell.Value.ToString();

            DataGridViewCell cell = dataGridView1.Rows[e.RowIndex].Cells[2];
            string documento = cell.Value.ToString();

            if (tipo != "Tipo") { 
            frmUpdate form = new frmUpdate(tipo, documento);
            form.FormClosed += formularioEnvio_FormClosed;
            form.ShowDialog();
                }
            }
        }
    }
}
