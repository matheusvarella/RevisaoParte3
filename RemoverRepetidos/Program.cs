using System;
using System.Collections;
using System.Collections.Generic;

namespace RemoverRepetidos
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<int> numero = new List<int>() { 1, 2, 3, 4, 5, 1, 2 };
            List<string> strings = new List<string>() { "teste", "teste", "teste", "outra" };

            List<Cliente> clientes = new List<Cliente>()
            {
                new Cliente("Wilson", "12345678978"),
                new Cliente("Robert", "12345678978"),
                new Cliente("Josoaldo", "32345678978"),
                new Cliente("Wilson", "22345678978"),
                new Cliente("Wilson", "42345678978"),
                new Cliente("Alfredo", "12345678978")
            };

            ExibirLista(numero);
            ExibirLista(strings);
            ExibirLista(clientes);

            numero.RemoveRepetidos();
            strings.RemoveRepetidos();
            clientes.RemoveRepetidos();

            ExibirLista(numero);
            ExibirLista(strings);
            ExibirLista(clientes);
        }

        private static void ExibirLista(IList lista)
        {
            foreach (var item in lista)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}
