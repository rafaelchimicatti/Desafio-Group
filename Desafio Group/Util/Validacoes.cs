using System.Text.RegularExpressions;

namespace Desafio_Group.Util
{
    static class Validacoes
    {
        public static bool DigitosIguais(string doc)
        {
            for (int i = 1; i < doc.Length; i++)
                {
                if (doc[i] != doc[0])
                    return false;
                }
            return true;
        }

        public static bool ValidarCPF(string cpf)
        {
            cpf = string.Join("", System.Text.RegularExpressions.Regex.Split(cpf, @"[^\d]"));
            cpf = cpf.Trim();

            if (cpf.Length != 11 || DigitosIguais(cpf))
                return false;

            int[] multiplicador1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            string tempCpf;
            string digito;
            int soma;
            int resto;

            tempCpf = cpf.Substring(0, 9);
            soma = 0;

            for (int i = 0; i < 9; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador1[i];

            resto = soma % 11;
            if (resto < 2)
                {
                resto = 0;
            }

            else
                {
                resto = 11 - resto;
            }

            digito = resto.ToString();
            tempCpf += digito;
            soma = 0;
            for (int i = 0; i < 10; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador2[i];

            resto = soma % 11;
            if (resto < 2)
                {
                resto = 0;
            }
            else
                {
                resto = 11 - resto;
            }

            digito += resto.ToString();
            return cpf.EndsWith(digito);
        }

        public static bool ValidarCNPJ(string cnpj)
        {
            int[] multiplicador1 = new int[12] { 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[13] { 6, 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };

            int soma;
            int resto;
            string digito;
            string tempCnpj;

            cnpj = string.Join("", System.Text.RegularExpressions.Regex.Split(cnpj, @"[^\d]"));
            cnpj = cnpj.Trim();

            if (cnpj.Length != 14 || DigitosIguais(cnpj)) { 
                return false;
            }

            tempCnpj = cnpj.Substring(0, 12);
            soma = 0;

            for (int i = 0; i < 12; i++) { 
                soma += int.Parse(tempCnpj[i].ToString()) * multiplicador1[i];
            }
            
            resto = soma % 11;

            if (resto < 2) { 
                resto = 0;
            }
            
            else { 
                resto = 11 - resto;
            }

            digito = resto.ToString();
            tempCnpj = tempCnpj + digito;
            soma = 0;

            for (int i = 0; i < 13; i++) { 
                soma += int.Parse(tempCnpj[i].ToString()) * multiplicador2[i];
            }
            
            resto = soma % 11;

            if (resto < 2) { 
                resto = 0;
            }

            else { 
                resto = 11 - resto;
            }

            digito += resto.ToString();

            return cnpj.EndsWith(digito);
        }

        public static bool ValidarEmail(string email)
        {
            string pattern = @"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$";

            return Regex.IsMatch(email, pattern);
        }

    }
}
