using System;

namespace Exercicio02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Action<string> portugues = nome => Console.WriteLine("Bem-vindo ao " + nome + "!");
            Action<string> ingles = nome => Console.WriteLine("Welcome to " + nome + "!");
            Action<string> espanhol = nome => Console.WriteLine("¡Bienvenido a " + nome + "!");

            Console.WriteLine("Escolha um idioma:");
            Console.WriteLine("1 - Português");
            Console.WriteLine("2 - Inglês");
            Console.WriteLine("3 - Espanhol");

            Console.Write("Digite sua opção: ");
            int opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    portugues("SaaS");
                    break;

                case 2:
                    ingles("SaaS");
                    break;

                case 3:
                    espanhol("SaaS");
                    break;

                default:
                    Console.WriteLine("Opção inválida!");
                    break;
            }
        }
    }
}