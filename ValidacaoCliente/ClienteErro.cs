using System.Collections.Generic;
using System.Linq;

namespace ValidacaoCliente
{
    public class ClienteErro
    {
        public string Dados { get; private set; }
        public Dictionary<string, string> Erros { get; private set; }

        public ClienteErro(Dictionary<string, string> erros)
        {
            List<KeyValuePair<string, string>> list = erros.ToList();
            
            for (int i = 0; i < list.Count; i++)
            {
                Dados += list[i].Key;
                if (i < list.Count - 1)
                    Dados += ", ";
            }

            Erros = erros;
        }
    }
}
