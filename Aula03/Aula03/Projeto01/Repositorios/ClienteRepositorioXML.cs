using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto01.Entidades;
using Projeto01.Contratos;
using System.Xml; //manipulação XML

namespace Projeto01.Repositorios
{
    public class ClienteRepositorioXML : IClienteRepositorio
    {
        public void Exportar(List<Cliente> clientes)
        {
            //abrir csv em modo de escrita
            string dataHora = DateTime.Now.ToString("ddMMyyyyHHmmss");
            string path = "c:\\temp\\clientes_" + dataHora + ".xml";

            XmlWriterSettings definicoes = new XmlWriterSettings();
            definicoes.Encoding = Encoding.GetEncoding("ISO-8859-1");
            definicoes.Indent = true;

            using (XmlWriter xml = XmlWriter.Create(path, definicoes))
            {
                xml.WriteStartDocument();
                xml.WriteStartElement("clientes");

                foreach (Cliente c in clientes)
                {
                    xml.WriteStartElement("cliente");
                    xml.WriteElementString("idCLiente", c.IdCliente.ToString());
                    xml.WriteElementString("nome", c.Nome);
                    xml.WriteElementString("sexo", c.Sexo.ToString());
                    xml.WriteElementString("estadoCivil", c.EstadoCivil.ToString());
                    xml.WriteEndElement();
                }

                xml.WriteEndElement();
            }

        }
    }
}
