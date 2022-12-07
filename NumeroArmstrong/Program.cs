using System;

namespace NumeroArmstrong
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe um número para validar se é um número de Armstrong");
            int numero = int.Parse(Console.ReadLine());

            if (numero.IsArmstrong())
            {
                Console.WriteLine("É um número de Armstrong!");
            } 
            else
            {
                Console.WriteLine("Não é um número de Armstrong!");
            }
        }
    }
}
