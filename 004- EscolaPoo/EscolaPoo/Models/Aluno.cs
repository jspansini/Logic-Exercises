using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscolaPoo.Models
{
    public class Aluno : Pessoa
    {
        public Aluno(string nome, int idade) : base(nome, idade)
        {
        }

        public override void Cumprimentar()
        {
            base.Cumprimentar();
            Console.WriteLine("Já estudo aqui tem anos!");
        }
        public void IrParaEscola()
        {
            Console.WriteLine("Estou indo pra escolaaaaaaaaa!");
        }
    }
}
