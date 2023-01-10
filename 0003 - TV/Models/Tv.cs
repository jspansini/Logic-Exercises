using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0003___TV.Models
{
    public class Tv
    {  
        public int Canal { get; set; }
        public int Volume { get; set; }
        public bool Ligada { get; set; }

        public Tv()
        {

        }
        public Tv(int canal, int volume, bool ligada)
        {
            this.Canal = canal;
            this.Volume = volume;
            this.Ligada = ligada;
        }

        public void DefinirValoresIniciais()
        {
            Console.WriteLine("Ligar tv? Sim ou não:");
            string resposta = Console.ReadLine().ToLower();
            if(resposta == "sim")
            {
                Ligada = true;
            }else
            {
                Ligada = false;
            }

            Console.WriteLine("Qual canal você quer ver?");
            int canalInicial = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Deseja aumentar volume?");
            bool boolInicial = bool.Parse(Console.ReadLine());
        }

        public bool Ligar()
        {
            return Ligada = true;
        }
        public bool Desligar()
        {
            return Ligada = false;       
        }
        public int MudarDeCanal()
        {
            if(Canal <= 0)
            {
                throw new ArgumentException("Erro");
            }
            else
            {
                return Canal;
            }
        }

        public int AumentarVolume()
        {
            return Volume++;
        }

        public int DiminuirVolume()
        {
            return Volume--;
        }
    }
}
