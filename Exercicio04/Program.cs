using System;

namespace Exercicio04
{
    class TemperatureSensor
    {
        public event Action<double> TemperatureExceeded;

        public void VerificarTemperatura(double temperatura)
        {
            if (temperatura > 100)
            {
                TemperatureExceeded(temperatura);
            }
        }
    }

    internal class Program
    {
        static void MostrarAlerta(double temperatura)
        {
            Console.WriteLine("ALERTA! Temperatura acima de 100°C: " + temperatura + "°C");
        }

        static void Main(string[] args)
        {
            TemperatureSensor sensor = new TemperatureSensor();

            sensor.TemperatureExceeded += MostrarAlerta;

            Console.Write("Quantas temperaturas deseja verificar? ");
            int quantidade = int.Parse(Console.ReadLine());

            for (int i = 0; i < quantidade; i++)
            {
                Console.Write("Digite a temperatura: ");
                double temperatura = double.Parse(Console.ReadLine());

                sensor.VerificarTemperatura(temperatura);
            }
        }
    }
}