
using System.ComponentModel.DataAnnotations;

namespace Entities
{

    public class Cliente
    {

        #region CONSTRUTORES
        public Cliente() { }
        public Cliente(string nome, char tipo, string documento, string email, string telefone, Endereco adress)
        {
            Nome = nome;
            Tipo = tipo;
            Documento = documento;
            Email = email;
            Telefone = telefone;
            Cidade = adress.Cidade;
            Bairro = adress.Bairro;
            Rua = adress.Rua;
            Numero  = adress.Numero;
        }

        #endregion

        #region ATRIBUTOS

        [Required(ErrorMessage = "O campo Nome é obrigatório.")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "É obrigatório selecionar o tipo de documento.")]
        public char Tipo { get; set; }

        public string Documento { get; set; }

        [Required(ErrorMessage = "O campo E-mail é obrigatório.")]
        public string Email { get; set; }

        public string Telefone { get; set; }


        [Required(ErrorMessage = "O campo Cidade é obrigatório.")]
        public string Cidade { get; set; }

        [Required(ErrorMessage = "O campo Bairro é obrigatório.")]
        public string Bairro { get; set; }

        [Required(ErrorMessage = "O campo Logradouro é obrigatório.")]
        public string Rua { get; set; }

        [Required(ErrorMessage = "O campo Número é obrigatório.")]
        public int Numero { get; set; }

        #endregion

    }
}