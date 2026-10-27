using System;

namespace Exercicio11
{
    internal class Program
    {
        static string Concatenar(string nome, string sobrenome)
        {
            return nome + " " + sobrenome;
        }

        static string Maiusculas(string nome, string sobrenome)
        {
            return (nome + " " + sobrenome).ToUpper();
        }

        static string RemoverEspacos(string nome, string sobrenome)
        {
            return (nome + " " + sobrenome).Replace(" ", "");
        }

        static void Main(string[] args)
        {
            Console.Write("Digite seu nome: ");
            string nome = Console.ReadLine();

            Console.Write("Digite seu sobrenome: ");
            string sobrenome = Console.ReadLine();

            Func<string, string, string> transformar = Concatenar;

            transformar += Maiusculas;
            transformar += RemoverEspacos;

            string resultado = transformar(nome, sobrenome);

            Console.WriteLine("Resultado: " + resultado);
        }
    }
}