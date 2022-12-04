using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace ValidacaoCliente
{
    public class LeitorClienteJson
    {
        private readonly List<ClienteDto> clientes;

        public LeitorClienteJson()
        {
            clientes= new List<ClienteDto>();
            var json = File.ReadAllText(@"C:\Users\Matheus\source\repos\RevisaoParte3\ValidacaoCliente\clientes.json");

            clientes = JsonSerializer.Deserialize<List<ClienteDto>>(json, new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
        }

        public List<ClienteDto> GetClientes()
        {
            return clientes;
        }
    }
}
