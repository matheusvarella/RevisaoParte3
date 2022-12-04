using System.Collections.Generic;

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
                    clienteErros.Add(new ClienteErro(item, clienteComErro));
            }

            if (clienteErros.Count > 0)
                EscreverClienteErroJson.EscreverClientesErrosJson(clienteErros);
        }
    }
}
