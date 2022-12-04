using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Json;
using System.Text;

namespace ValidacaoCliente
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ClienteController.ExecutarProcesso();
        }
    }
}
