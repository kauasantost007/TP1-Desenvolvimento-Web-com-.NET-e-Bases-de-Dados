using System;
using System.IO;

namespace Exercicio07
{
    class Logger
    {
        public void LogToConsole(string mensagem)
        {
            Console.WriteLine("Console: " + mensagem);
        }

        public void LogToFile(string mensagem)
        {
            File.AppendAllText("logs.txt", mensagem + Environment.NewLine);
        }

        public void LogToDatabase(string mensagem)
        {
            Console.WriteLine("Banco de dados: " + mensagem);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Logger logger = new Logger();

            Action<string>? log = null;

            log?.Invoke("Teste sem métodos associados.");

            log += logger.LogToConsole;
            log += logger.LogToFile;
            log += logger.LogToDatabase;

            log?.Invoke("Registro realizado com sucesso!");
        }
    }
}