using System;

namespace Exercicio01
{
    internal class Program
    {
        delegate decimal CalculateDiscount(decimal preco);

        static decimal AplicarDesconto(decimal preco)
        {
            return preco * 0.90m;
        }

        static void Main(string[] args)
        {
            Console.Write("Digite o preço original do produto: ");
            decimal preco = decimal.Parse(Console.ReadLine());

            CalculateDiscount desconto = AplicarDesconto;

            decimal precoFinal = desconto(preco);

            Console.WriteLine("Preço final com 10% de desconto: R$ " + precoFinal.ToString("F2"));
        }
    }
}