using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto01.Entidades;
using Projeto01.Servicos;
using Projeto01.Contratos;

namespace Projeto01.Controladores
{
    public class MensagemControle
    {
        public void EnviarMensagem()
        {
            try
            {
                Console.WriteLine("\n - Envio de Mensagem - \n");
                Mensagem msg = new Mensagem();
                Console.WriteLine("Informe o email de destino...: ");
                msg.EmailDest = Console.ReadLine();

                Console.WriteLine("Informe o Assunto...: ");
                msg.Assunto = Console.ReadLine();

                Console.WriteLine("Informe o conteudo da mensagem..: ");
                msg.Conteudo = Console.ReadLine();

                IMensagemService service = new MensagemService();
                service.EnviarEmail(msg);

                Console.WriteLine("\n Email Enviado com Sucesso!!! \n");
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: "+ e.Message);
            }
        }
    }
}
