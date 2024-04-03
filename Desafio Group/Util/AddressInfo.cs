using System;
using System.Net.Http;
using Entities;
using Newtonsoft.Json;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;


public class AddressInfo
{

    #region ATRIBUTOS
    public string CEP { get; set; }
    public string Logradouro { get; set; }
    public string Complemento { get; set; }
    public string Bairro { get; set; }
    public string Localidade { get; set; }
    public string UF { get; set; }
    public string IBGE { get; set; }
    public string GIA { get; set; }
    public string DDD { get; set; }
    public string Siafi { get; set; }

    #endregion

    #region MÉTODOS
    public static Endereco APIEndereco(string CEP)
    {

        AddressInfo address = GetAddressInfo(CEP);

        if (address != null)
        {
            Endereco enderecoAux = new Endereco(address.Localidade, address.Bairro, address.Logradouro);
            return enderecoAux; 
        }
        else
        {
            Console.WriteLine("Endereço não encontrado.");
            return null;
        }
    }

    static bool AcceptAllCertifications(object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors)
    {
        return true;
    }

    public static AddressInfo GetAddressInfo(string cep)
    {
        HttpClientHandler handler = new HttpClientHandler();
        handler.ServerCertificateCustomValidationCallback = AcceptAllCertifications;

        using (HttpClient client = new HttpClient(handler))
        {
            string url = $"https://viacep.com.br/ws/{cep}/json/";
            HttpResponseMessage response = client.GetAsync(url).Result;

            if (response.IsSuccessStatusCode)
            {
                string json = response.Content.ReadAsStringAsync().Result;
                AddressInfo address = JsonConvert.DeserializeObject<AddressInfo>(json);
                return address;
            }
            else
            {
                return null;
            }
        }
    }

    #endregion

}

