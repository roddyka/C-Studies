using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto01.Entidades
{
    public class Mensagem
    {
        #region Propriedades
        public string EmailDest { get; set; }
        public string Assunto { get; set; }
        public string Conteudo { get; set; }
        #endregion

        #region Construtores
        //construtor default
        public Mensagem()
        {
                //vazio
        }
        //sobrecarga de construtores(overloading)
        public Mensagem(string emailDest, string assunto, string conteudo)
        {
            EmailDest = emailDest;
            Assunto = assunto;
            Conteudo = conteudo;
        }
        #endregion

        #region Sobrescrita de Métodos
        public override string ToString()
        {
            return $"Email Dest: {EmailDest}, Assunto: {Assunto}, Conteudo: {Conteudo}";
        }
        #endregion
    }
}
