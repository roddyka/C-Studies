using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using Projeto01.Entities;
using Projeto01.Contract;

namespace Projeto01.Repositories
{
    class FuncionarioExportarXML : IFuncionarioRepositorio
    {
        public void Exportar(List<Programador> programador)
        {
            string dataHora = DateTime.Now.ToString("ddMMyyyyHHmmss");
            string path = "c:\\temp\\clientes_" + dataHora + ".xml";

            XmlWriterSettings definicoes = new XmlWriterSettings();
            definicoes.Encoding = Encoding.GetEncoding("ISO-8859-1");
            definicoes.Indent = true;

            using (XmlWriter xml = XmlWriter.Create(path, definicoes))
            {
                xml.WriteStartDocument();
                xml.WriteStartElement("Programadores");

                foreach(Programador p in programador)
                {
                    xml.WriteStartElement("Programador");
                    xml.WriteElementString("IdProgramador", p.IdFunctionario.ToString());
                    xml.WriteElementString("Sexo", p.Sexo.ToString());
                    xml.WriteElementString("EstadoCivil", p.EstadoCivil.ToString());
                    xml.WriteElementString("Nome", p.Nome);
                    xml.WriteElementString("TipoDepartamento", p.tipo.ToString());
                    xml.WriteElementString("Salario", p.Salario.ToString());
                    xml.WriteElementString("NumeroDepto", p.tipo.ToString());
                    xml.WriteElementString("Área", p.departamento.ToString());
                    xml.WriteEndElement();

                }

                xml.WriteEndElement();
            }
        }
    }
}
