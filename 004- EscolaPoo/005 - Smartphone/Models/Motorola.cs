using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _005___Smartphone.Models
{
    public class Motorola : Smartphone
    {
        public Motorola(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {

        }
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Estou instalando o {nomeApp} no meu Motorola via PlayStore!");
        }
    }
}
