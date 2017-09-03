using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.Entities
{
    public class Usuario
    {
        //proptiedades
        public int IdUsuario { get; set; }
        public string Nome { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
        public string Foto { get; set; }

        //construtor
        public Usuario()
        {
                
        }

        //overloading 
        public Usuario(int idUsuario,string nome, string login, string senha, string foto)
        {
            IdUsuario = idUsuario;
            Nome = nome;
            Login = login;
            Senha = senha;
            Foto = foto;
        }

        //sobrescrita
        public override string ToString()
        {
            return $"Id: {IdUsuario}, Nome: {Nome}, Login: {Login}";
        }

    }
}
