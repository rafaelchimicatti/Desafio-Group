using System;
using System.Net;
using System.Net.Mail;

namespace Desafio_Group.Util
{
    public static class Recuperacao
    {
        public static void EnviarEmailRecuperacao(string emailDestinatario, int codigoRecuperacao)
        {
            string emailRemetente = "testegroupdesafio@outlook.com";
            string senhaRemetente = "@Group123";
            string assunto = "Código de Recuperação de Senha";
            string corpoEmail = $"Seu código de recuperação de senha é: {codigoRecuperacao}";

            MailMessage mensagem = new MailMessage(emailRemetente, emailDestinatario, assunto, corpoEmail);

            SmtpClient clienteSmtp = new SmtpClient("smtp.office365.com", 587);
            clienteSmtp.UseDefaultCredentials = false;
            clienteSmtp.Credentials = new NetworkCredential(emailRemetente, senhaRemetente);
            clienteSmtp.EnableSsl = true;

            try
            {
                clienteSmtp.Send(mensagem);
                Console.WriteLine("E-mail de recuperação enviado com sucesso!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao enviar e-mail de recuperação: {ex.Message}");
            }
        }
    }
}
