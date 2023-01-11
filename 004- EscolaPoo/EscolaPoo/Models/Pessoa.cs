using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscolaPoo.Models
{
    public class Pessoa
    {
        protected string Nome { get; set; }
        protected int Idade { get; set; }


        public Pessoa(string nome, int idade)
        {
            this.Nome = nome;
            this.Idade = idade;
        }

        //métodos
        public virtual void Cumprimentar()
        {
            Console.WriteLine($"Oieee, cheguei! Meu nome é {Nome}!");
        }
        
        public void DizerIdade()
        {
            Console.WriteLine($"E já tenho {Idade} anos!");
        }
    }
}
