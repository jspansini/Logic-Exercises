﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _005___Smartphone.Models
{
    public abstract class Smartphone
    {
            public string Numero { get; set; }
            public string Modelo { get; set; }
            public string Imei { get; set; }
            public int Memoria { get; set; }

            public Smartphone(string numero, string modelo, string imei, int memoria)
            {
                this.Numero = numero;
                this.Modelo = modelo;
                this.Imei = imei;
                this.Memoria = memoria;
            }

            public void Ligar()
            {
                Console.WriteLine("Ligando...");
            }

            public void ReceberLigacao()
            {
                Console.WriteLine("Recebendo ligação...");
            }

            public abstract void InstalarAplicativo(string nomeApp);
        
    }
}
