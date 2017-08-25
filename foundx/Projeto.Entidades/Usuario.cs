using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto.Entidades.Tipos;  
namespace Projeto.Entidades
{
    public class Usuario
    {
        public int IdUsuario { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Email { get; set; }
        public DateTime DataNascimento { get; set; }
        public Sexo Sexo { get; set; }
        public EstadoCivil EstadoCivil { get; set; }
        public string Profissao { get; set; }
        public Area Area { get; set; }
        public string Descricao { get; set; }
        public decimal PretencaoSalarial { get; set; }
        public string Linkedin { get; set; }
        public string Senha { get; set; }

        public Usuario()
        {

        }

        public Usuario(int idUsuario, string nome, string sobrenome, string email, DateTime dataNascimento, Sexo sexo, EstadoCivil estadoCivil, string profissao, Area area, string descricao, decimal pretencaoSalarial, string linkedin, string senha)
        {
            IdUsuario = idUsuario;
            Nome = nome;
            Sobrenome = sobrenome;
            Email = email;
            DataNascimento = dataNascimento;
            Sexo = sexo;
            EstadoCivil = estadoCivil;
            Profissao = profissao;
            Area = area;
            Descricao = descricao;
            PretencaoSalarial = pretencaoSalarial;
            Linkedin = linkedin;
            Senha = senha;
        }

        public override string ToString()
        {
            return $"Nome: {Nome}, Sobrenome: {Sobrenome}, Email: {Email}, Data de Nascimento: {DataNascimento}, Sexo: {Sexo}, Estado Civil: {EstadoCivil}, Profissão: {Profissao}, Área: {Area}, Descrição: {Descricao}, Pretenção Salárial: {PretencaoSalarial}, Linkedin: {Linkedin}";
        }
    }
}
