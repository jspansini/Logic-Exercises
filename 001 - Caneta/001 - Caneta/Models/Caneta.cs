using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001___Caneta.Models
{
    public enum ModeloCaneta
    {
        Bic,
        Compactor,
        MarcaCis           
    }
    public enum TiposDePonta
    {
        PontaGrossa,
        PontaMedia,
        PontaFina
    }
    public class Caneta

    {
        public int Codigo { get; set; }
        public ModeloCaneta Modelo { get; set; }
        public string Cor { get; set; }
        public TiposDePonta Ponta { get; set; }
        public bool Tampada { get; set; }
        public double Preco { get; set; }
        public Caneta(int codigo, ModeloCaneta modelo, string cor,TiposDePonta ponta, bool tampada, double preco)
        {
            this.Codigo = codigo;
            this.Modelo = modelo;
            this.Cor = cor;
            this.Tampada = tampada;
            this.Preco = preco;
            this.Ponta = ponta;
        }

        public Caneta()
        {
        }

        public string Rabiscar()
        {
            if (Ponta.Equals(TiposDePonta.PontaGrossa)){
                return "Toda vez que você chama eu rabisco algo SAI GROOOOOOOSSSO";
            }else if (Ponta.Equals(TiposDePonta.PontaMedia))
            {
                return "Toda vez que você chama eu rabisco algo SAI MEDIOOOOOO";
            }
            else
            {
                return "Toda vez que você chama eu rabisco algo SAI FIIIIIIIIIIIIINO";
            }
        }

        public string Escrever(string mandaAlgo)
        {
            if(mandaAlgo != null)
            {
                return $"Taí o que você queria escrito em tela: {mandaAlgo}";
            }
            else
            {
                return "erro!";
            }
        }

        public string TamparOuDestampar()
        {
            this.Tampada = Tampada;
            if(!Tampada)
            {
                Tampada = true;
                return "Agora você fechou!";
            }
            else
            {
                Tampada = false;
                return "Agora você abriu!";
            }
        }
    }
}
