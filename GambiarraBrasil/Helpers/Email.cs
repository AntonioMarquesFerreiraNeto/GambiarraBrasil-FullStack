using GambiarraBrasil.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using System;
using System.Net;
using System.Net.Mail;

namespace GambiarraBrasil.Helpers {
    public class Email : IEmail {
        private IConfiguration _configuration;

        public Email(IConfiguration configuration) {
            _configuration = configuration;
        }

        public bool EnviarRedefinicaoSenha(Usuario usuario, string urlDefinicao) {
            try {
                if (!string.IsNullOrEmpty(usuario.Email) && !string.IsNullOrEmpty(usuario.Name)) {
                    string tema = "Gambiarra Brasil - Recuperação de conta";
                    string conteudo = $"Olá, {usuario.Name}. Você acessou nosso serviço de recuperação de conta recentemente." +
                        $"\nPortanto, acesse o link a seguir para recuperar sua conta: <strong><a href=\"{urlDefinicao}\" target=\"_blank\">Redefinir senha</a></strong>";
                    return Enviar(usuario.Email, tema, conteudo);
                }
                else {
                    return false;
                }
            }
            catch (Exception error) {
                throw new Exception(error.Message);
            }
        }

        public bool Enviar(string email, string tema, string conteudo) {
            try {
                string host = _configuration.GetValue<string>("SMTP:Host");
                string nome = _configuration.GetValue<string>("SMTP:Name");
                string remetente = _configuration.GetValue<string>("SMTP:UserName");
                string senha = _configuration.GetValue<string>("SMTP:Senha");
                int porta = _configuration.GetValue<int>("SMTP:Porta");

                MailMessage mail = new MailMessage() {
                    From = new MailAddress(remetente, nome)
                };

                mail.To.Add(email);
                mail.Subject = tema;
                mail.Body = conteudo;
                mail.IsBodyHtml = true;
                mail.Priority = MailPriority.High;

                using (SmtpClient smtp = new SmtpClient(host, porta)) {
                    smtp.Credentials = new NetworkCredential(remetente, senha);
                    smtp.EnableSsl = true;

                    smtp.Send(mail);
                    return true;
                }
            }
            catch (Exception error) {
                return false;
            }
        }
    }
}
