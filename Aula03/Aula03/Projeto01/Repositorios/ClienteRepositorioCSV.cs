using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto01.Entidades;
using Projeto01.Contratos;
using System.IO;

namespace Projeto01.Repositorios
{
    public class ClienteRepositorioCSV : IClienteRepositorio
    {
        public void Exportar(List<Cliente> clientes)
        {
            //abrir csv em modo de escrita
            string dataHora = DateTime.Now.ToString("ddMMyyyyHHmmss");
            string path = "c:\\temp\\clientes_" + dataHora + ".csv";

            using(StreamWriter sw = new StreamWriter(path))
            {
                foreach(Cliente c in clientes)
                {
                    sw.WriteLine($"{c.IdCliente};{c.Nome};{c.Sexo};{c.EstadoCivil}");
                }
            }

        }
    }
}
