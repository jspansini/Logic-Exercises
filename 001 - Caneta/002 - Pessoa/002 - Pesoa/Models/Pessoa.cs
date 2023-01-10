using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002___Pesoa.Models
{
    public class Pessoa
    {
        public string NomeCompleto { get; set; }
        public string Email { get; set; }
        public string PrimeiroNome { get; set; }

        public Pessoa(string nome, string email, string primeiroNome)
        {
            this.NomeCompleto = nome;
            this.Email = email;
            this.PrimeiroNome = primeiroNome;
        }

        public string Comprimentar()
        {
            return $"Olá, {NomeCompleto} tudo bem com você? Seu email é {Email} ";
        }

    }



}
