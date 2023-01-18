using _007___Interface.Interfaces;
using Poo2_Ex4_Interface.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _007___Interface.Models.Animais
{
    public class Ornitorrinco : Ave, IVoar, IOviparo, IAquatico
    {
        public bool ViveEmTerra { get; set; } = true;
        public bool Mergulho { get; set; }
        public bool AguaDoce { get; set; }
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
        public void TodosOsMetodos()
        {
            Console.WriteLine("Faço tudo e não faço nada bem feito! Sou o ornitorrinco");
        }
    }

}
