using System.Collections.Generic;

namespace ValidacaoCliente
{
    public class ClienteErro
    {
        public ClienteDto dados { get; private set; }
        public Dictionary<string, string> erros { get; private set; }

        public ClienteErro(ClienteDto dados, Dictionary<string, string> erros)
        {
            this.dados = dados;
            this.erros = erros;
        }
    }
}
