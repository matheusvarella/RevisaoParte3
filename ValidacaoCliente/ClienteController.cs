using System.Collections.Generic;
using System.Text.Json;

namespace ValidacaoCliente
{
    public static class ClienteController
    {
        public static void ExecutarProcesso()
        {
            var leitorCliente = new LeitorClienteJson();

            var clienteErros = new List<ClienteErro>();

            foreach (var item in leitorCliente.GetClientes())
            {
                var clienteComErro = ValidadorCliente.ValidarCliente(item);

                if (clienteComErro != null)
                    clienteErros.Add(new ClienteErro(clienteComErro));
            }

            EscreverClienteErroJson.EscreverClientesErrosJson(clienteErros);
        }
    }
}
