using System;
using System.IO;

namespace Exercicio06
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

            Action<string> log = logger.LogToConsole;

            log += logger.LogToFile;
            log += logger.LogToDatabase;

            log("Registro realizado com sucesso!");
        }
    }
}