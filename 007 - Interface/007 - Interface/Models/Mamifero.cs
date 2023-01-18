using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _007___Interface.Models
{
    public class Mamifero : Animal
    {
        public int QtdDeMamas { get; set; }
        public bool Pelos { get; set; }
        public string CorDoPelo { get; set; }

        public void Amamentar()
        {
            Console.WriteLine("Amamentando...");
        }
    }
}

