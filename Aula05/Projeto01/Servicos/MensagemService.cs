using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto01.Entidades;
using Projeto01.Contratos;
using System.Net;//servicos de rede
using System.Net.Mail;//envio de email

namespace Projeto01.Servicos
{
    public class MensagemService : IMensagemService
    {
        private readonly string conta = "cotiexemplo@gmail.com";
        private readonly string senha = "@coticoti@";
        private readonly string smtp = "smtp.gmail.com";
        private readonly int porta = 587;

        public void EnviarEmail(Mensagem msg)
        {
            //1 - PASSO PARA ENVIAR EMAIL ( CRIAR MENSAGEM )
            MailMessage mail = new MailMessage(conta, msg.EmailDest); //De -> Para
            mail.Subject = msg.Assunto;
            mail.Body = msg.Conteudo;

            // 2 - configurar protocolo smtp de envio
            SmtpClient client = new SmtpClient(smtp, porta);
            client.EnableSsl = true;//ssl (security)
            client.Credentials = new NetworkCredential(conta, senha);

            //enviando mesagem
            client.Send(mail);

        }
    }
}
