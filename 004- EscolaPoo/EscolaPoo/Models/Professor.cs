using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace EscolaPoo.Models
{
    public class Professor : Pessoa
    {
        public Professor(string nome, int idade) : base(nome, idade)
        {

        }

        public override void Cumprimentar()
        {
            base.Cumprimentar();
            Console.WriteLine("Vou ser seu professor neste semestre!\n");
        }
        public void ExplicarAssunto()
        {
            bool check;
            int resp, respAssunto;
            Console.WriteLine("Sobre qual assunto você gostaria de saber?");
            do
            {
                Console.WriteLine("(1) - Frutas ou (2) - Esportes!");
                check = int.TryParse(Console.ReadLine(), out resp);
            } while (!check || resp != 1 && resp != 2);


            switch (resp)
            {
                case 1:
                    Console.WriteLine("Eu sei sobre: ");
                    Console.WriteLine("1 - Abacaxi\n2 - Melancia\n3 - Ameixa\n");
                    Console.WriteLine("Sobre qual deles você quer saber?");
                    check = int.TryParse(Console.ReadLine(), out respAssunto);
                    AssuntoFrutas(respAssunto);

                    break;
                case 2:
                    Console.WriteLine("Eu sei sobre: ");
                    Console.WriteLine("1 - Futebol\n2 - Basquete\n3 - Skateboard\n");
                    Console.WriteLine("Sobre qual deles você quer saber?");
                    check = int.TryParse(Console.ReadLine(), out respAssunto);
                    AssuntoEsportes(respAssunto);
                    break;
            }
        }

        //GrupoDeAssuntos
        public void AssuntoFrutas(int respAssunto)
        {

            if (respAssunto == 1)
            {
                Console.WriteLine("Uma junção dos termos tupis i'bá e ká'ti! O kiwi é lindo!");
            }
            else if (respAssunto == 2)
            {
                Console.WriteLine("Uma fruta bastante refrescante que possui vitamina C, A, além de minerais!");
            }
            else if (respAssunto == 3)
            {
                Console.WriteLine("Uma fruta de polpa firme das variedades de Prunus domestica que têm um alto teor de sólidos");
            }
            else
            {
                Console.WriteLine("Numero inválido!");
            }
        }

        public void AssuntoEsportes(int respAssunto)
        {
            if (respAssunto == 1)
            {
                Console.WriteLine("O futebol é o esporte coletivo mais praticado do mundo. É disputado por duas equipes, de 11 jogadores que têm como objetivo colocar a bola entre as traves adversárias");
            }
            else if (respAssunto == 2)
            {
                Console.WriteLine("Um esporte coletivo jogado por duas equipes, que têm o objetivo de fazer pontos ao acertar a bola na cesta do adversário, o alvo fixo na quadra.");
            }
            else if (respAssunto == 3)
            {
                Console.WriteLine("Im esporte que consiste em deslizar sobre o solo e obstáculos equilibrando-se numa prancha!");
            }
            else
            {
                Console.WriteLine("Numero inválido!");
            }
        }

    }

    }

