using System;
using System.ComponentModel.DataAnnotations;

namespace Entities
{
    public class Endereco
    {
        #region CONSTRUTORES
        public Endereco(string cidade, string bairro, string rua, int numero) { 
           Cidade = cidade;
           Bairro = bairro;
           Rua = rua;
           Numero = numero;
        }

        public Endereco(string cidade, string bairro, string rua)
        {
            Cidade = cidade;
            Bairro = bairro;
            Rua = rua;
        }

        #endregion

        #region ATRIBUTOS

        [Required(ErrorMessage = "O campo Cidade é obrigatório.")]
        public string Cidade { get; set; }

        [Required(ErrorMessage = "O campo Bairro é obrigatório.")]
        public string Bairro { get; set; }

        [Required(ErrorMessage = "O campo Logradouro é obrigatório.")]
        public string Rua { get; set; }

        [Required(ErrorMessage = "O campo Número é obrigatório.")]
        public int Numero { get; set; }

        #endregion

        #region METODOS

        public string formatarEndereco()
        {
            string formatada = this.Cidade + ", " + this.Bairro + ", " + this.Rua + ", " + this.Numero;
            return formatada;
        }

        #endregion

    }
}
