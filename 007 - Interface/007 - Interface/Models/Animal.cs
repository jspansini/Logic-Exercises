using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _007___Interface.Models
{
    public abstract class Animal
    {
        public string Nome { get; set; }
        public DateTime DataDeNascimento { get; set; }
        public char Sexo { get; set; }
        public int Idade { get; set; }
        public bool Carnivoro { get; set; }
        public bool Peconhento { get; set; }

        public void Movimentar()
        {
            Console.WriteLine("Atenção! Animal em movimento...");
        }

        public void Comunicar()
        {
            Console.WriteLine("Atenção! Animal se comunicando...");
        }

        public void Alimentar()
        {
            Console.WriteLine("Atenção! Animal comendo...");
        }
    }
}