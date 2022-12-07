using System;
using System.IO;

namespace IndiceRemissivo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var indice = new IndiceRemissivo(
                @"C:\Users\Matheus\source\repos\RevisaoParte3\IndiceRemissivo\texto.txt",
                @"C:\Users\Matheus\source\repos\RevisaoParte3\IndiceRemissivo\ignore.txt");
        }
    }
}
