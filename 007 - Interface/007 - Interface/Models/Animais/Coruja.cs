using _007___Interface.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _007___Interface.Models.Animais
{
    public class Coruja : Ave, IVoar, IOviparo
    {
        public int AltitudeMaximaEmMetros { get; set; }
        public double VelocidadeDoVoo { get; set; }

        public void Botar()
        {
            Console.WriteLine("Estou botando...");
        }

        public void Chocar()
        {
            Console.WriteLine("Estou chocando...");
        }

        public void Voar()
        {
            Console.WriteLine("Estou voandooo...");
        }
    }
}
