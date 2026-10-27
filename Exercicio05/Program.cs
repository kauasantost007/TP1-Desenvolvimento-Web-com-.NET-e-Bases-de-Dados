using System;
using System.Threading;

namespace Exercicio05
{
    class DownloadManager
    {
        public event Action DownloadCompleted;

        public void IniciarDownload()
        {
            Console.WriteLine("Download iniciado...");

            Thread.Sleep(3000);

            DownloadCompleted();
        }
    }

    internal class Program
    {
        static void MostrarMensagem()
        {
            Console.WriteLine("Download concluído com sucesso!");
        }

        static void Main(string[] args)
        {
            DownloadManager download = new DownloadManager();

            download.DownloadCompleted += MostrarMensagem;

            download.IniciarDownload();
        }
    }
}