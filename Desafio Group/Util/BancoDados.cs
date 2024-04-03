using Entities;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Text;
using System.Linq;
using System.Collections.Generic;

namespace Desafio_Group.Util
{
    static class BancoDados
    {

        public static SqlConnection Conectar()
        {
            string sqlconnection = "Data Source=GROUP-NOTE02131;Initial Catalog=DesafioGroup;User id=sa;Password=admin123;Integrated Security=False";
            SqlConnection conn = new SqlConnection(sqlconnection);
            try
            {
                conn.Open();
                return conn;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static DataTable MostrarTodos()
        {
            try
            {
                using (SqlConnection connection = BancoDados.Conectar())
                {
                    string query = "SELECT * FROM Clientes;";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            DataTable dataTable = new DataTable();
                            dataTable.Load(reader);
                            return dataTable;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void AdicionarCliente(Cliente novoCliente)
        {
            try
            {
                using (SqlConnection connection = BancoDados.Conectar())
                {
                    string query = "INSERT INTO Clientes VALUES (@Nome, @Tipo, @Documento, @Email, @Telefone, @Cidade, @Bairro, @Logradouro, @Numero);";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Nome", novoCliente.Nome);
                        command.Parameters.AddWithValue("@Tipo", novoCliente.Tipo);
                        command.Parameters.AddWithValue("@Documento", novoCliente.Documento);
                        command.Parameters.AddWithValue("@Email", novoCliente.Email);
                        command.Parameters.AddWithValue("@Telefone", novoCliente.Telefone);
                        command.Parameters.AddWithValue("@Cidade", novoCliente.Cidade);
                        command.Parameters.AddWithValue("@Bairro", novoCliente.Bairro);
                        command.Parameters.AddWithValue("@Logradouro", novoCliente.Rua);
                        command.Parameters.AddWithValue("@Numero", novoCliente.Numero);

                        // Executar a consulta
                        int rowsAffected = command.ExecuteNonQuery();

                        // Verificar se a inserção foi bem-sucedida
                        if (rowsAffected > 0)
                        {
                            Console.WriteLine("Inserção bem-sucedida!");
                        }
                        else
                        {
                            Console.WriteLine("Nenhuma linha inserida.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public static DataTable Pesquisar(string pesquisa)
        {
            try
            { 
                if (pesquisa == "")
            {
                return MostrarTodos();
            }
                using (SqlConnection connection = BancoDados.Conectar())
                {
                    string query = "SELECT * FROM Clientes WHERE Nome = @Nome OR Documento = @Documento;";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Nome", pesquisa);
                        command.Parameters.AddWithValue("@Documento", pesquisa);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            DataTable dataTable = new DataTable();
                            dataTable.Load(reader);
                            return dataTable;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void AdicionarUsuario(string email, string senha)
        {
            try { 
            Random random = new Random();
            int token = random.Next(100000, 999999);
            using (SqlConnection connection = BancoDados.Conectar())
            {
                string query = "INSERT INTO Usuarios (Email, Senha, Token) VALUES (@Email, @Senha, @Token)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Email", email);
                command.Parameters.AddWithValue("@Senha", BancoDados.CalcularSHA256(senha));
                command.Parameters.AddWithValue("@Token", token);

                command.ExecuteNonQuery();
            }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static bool VerificarCredenciais(string email, string senha)
        {
            try { 
            using (SqlConnection connection = BancoDados.Conectar())
                {
                string query = "SELECT COUNT(*) FROM Usuarios WHERE Email = @Email AND Senha = @Senha";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Email", email);
                command.Parameters.AddWithValue("@Senha", BancoDados.CalcularSHA256(senha));

                int count = (int)command.ExecuteScalar();

                return count > 0;
                }   
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static string CalcularSHA256(string input)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                // Convertendo a string de entrada para um array de bytes
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(input));

                // Convertendo o array de bytes para uma string hexadecimal
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }

        public static bool ExisteEmail(string email)
        {
            try
            {
                using (SqlConnection connection = BancoDados.Conectar())
                {
                    string query = "SELECT COUNT(*) FROM Usuarios WHERE Email = @Email;";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {

                        command.Parameters.AddWithValue("@Email", email);
                        int quantidadeEmails = (int)command.ExecuteScalar();

                        if(quantidadeEmails > 0) { return true; }
                        else { return false; }

                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static int ConsultarCodigo(string email) 
        
        {
            try
            {
                using (SqlConnection connection = BancoDados.Conectar())
                {
                    string query = "SELECT Token FROM Usuarios WHERE Email = @Email;";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {

                        command.Parameters.AddWithValue("@Email", email);
                        int token = (int)command.ExecuteScalar();

                        return token;
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public static bool AtualizaSenha(string email, string senha, string token)
        {
            int Token = int.Parse(token);

            if (ConsultarCodigo(email) != Token)
            {
                MessageBox.Show("Código incorreto.");
                return false;
            }

            try
            {
                using (SqlConnection connection = BancoDados.Conectar())
                {
                    string query = "UPDATE Usuarios SET SENHA = @Senha WHERE Email = @Email AND Token = @Token;";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {

                        command.Parameters.AddWithValue("@Email", email);
                        command.Parameters.AddWithValue("@Senha", BancoDados.CalcularSHA256(senha));
                        command.Parameters.AddWithValue("@Token", Token);

                        command.ExecuteNonQuery();
                        ModificarCodigo(email);
                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void ModificarCodigo(string email)
        {
            Random random = new Random();
            int novoToken = random.Next(100000, 999999);

            try
            {
                using (SqlConnection connection = BancoDados.Conectar())
                {
                    string query = "UPDATE Usuarios SET Token = @novoToken WHERE Email = @Email;";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {

                        command.Parameters.AddWithValue("@Email", email);
                        command.Parameters.AddWithValue("@novoToken", novoToken);

                        command.ExecuteNonQuery();

                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public static void Remover(string documento)
        {
            try
            {
                using (SqlConnection connection = BancoDados.Conectar())
                {
                    string query = "DELETE FROM Clientes WHERE Documento = @Documento;";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {

                        command.Parameters.AddWithValue("@Documento", documento);
                        command.ExecuteNonQuery();

                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void AtualizarDado(string documento, string tipoDado, string dadoNovo)
        {
            try
            {
                if(dadoNovo == "")
                {
                    MessageBox.Show("Dado não pode ser vazio.");
                        return;
                }
                if(tipoDado == "Documento")
                {
                    if (!Validacoes.ValidarCNPJ(dadoNovo) && !Validacoes.ValidarCPF(dadoNovo))
                    {
                        MessageBox.Show("Documento inválido.");
                        return;
                    }
                }
                if (tipoDado == "Email")
                {
                    if (!Validacoes.ValidarEmail(dadoNovo))
                    {
                        MessageBox.Show("E-mail inválido.");
                        return;
                    }
                }

                if (tipoDado == "Rua")
                    {
                        tipoDado = "Logradouro";
                    }
                    using (SqlConnection connection = BancoDados.Conectar())
                {
                    string query = "UPDATE Clientes SET " + tipoDado + " = @dadoNovo WHERE Documento = @Documento;";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {

                        command.Parameters.AddWithValue("@dadoNovo", dadoNovo);
                        command.Parameters.AddWithValue("@Documento", documento);
                        command.ExecuteNonQuery();

                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static List<Cliente> AtualizarLinq()
        {
            List<Cliente> listaCliente = new List<Cliente>();
            SqlDataReader reader;
            Cliente cliente = new Cliente();

            try
            {
                using (SqlConnection connection = BancoDados.Conectar())
                {
                    string query = "SELECT * FROM Clientes;";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {

                            reader = command.ExecuteReader();

                        while (reader.Read())
                        {
                            cliente = new Cliente();
                            cliente.Nome = reader["Nome"].ToString();
                            cliente.Documento = reader["Documento"].ToString();
                            string tipo = reader["Tipo"].ToString();
                            cliente.Tipo = Convert.ToChar(tipo);
                            cliente.Email = reader["Email"].ToString();
                            cliente.Telefone = reader["Telefone"].ToString();

                            cliente.Cidade = reader["Cidade"].ToString();
                            cliente.Bairro = reader["Bairro"].ToString();
                            cliente.Rua = reader["Logradouro"].ToString();
                            string numero = reader["Numero"].ToString();
                            cliente.Numero = int.Parse(numero);

                            listaCliente.Add(cliente);
                        }
                        reader.Close();
                    }
                    return listaCliente;
                }
            } 
            catch(Exception ex)
            {
                throw ex;
            }

        }

    }
}
