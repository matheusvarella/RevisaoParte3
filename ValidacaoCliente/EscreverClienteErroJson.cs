using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace ValidacaoCliente
{
    public static class EscreverClienteErroJson
    {
        public static void EscreverClientesErrosJson(List<ClienteErro> erros) 
        {
            var json = JsonSerializer.Serialize(erros, new JsonSerializerOptions { WriteIndented = true });

            File.WriteAllText(@"C:\Users\Matheus\source\repos\RevisaoParte3\ValidacaoCliente\erros.json", json);
        }
    }
}
