using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace Projeto.Util
{
    public class Criptografia
    {
        public static string GetMD5Hash(string valor)
        {
            try
            {
                MD5 md5 = new MD5CryptoServiceProvider();

                //converter o parametro 'valor' para bytes
                byte[] valorBytes = Encoding.UTF8.GetBytes(valor);

                //aplicar a criptografia..
                byte[] hash = md5.ComputeHash(valorBytes);

                StringBuilder resultado = new StringBuilder();
                foreach(byte b in hash) //varrendo o hash MD5
                {
                    resultado.Append(b.ToString("X")); //X -> HEXADECIMAL..
                }

                return resultado.ToString(); //retornando o HASH em string..
            }
            catch(Exception e)
            {
                throw new Exception("Erro ao encriptar: " + e.Message);
            }
        }
    }
}
