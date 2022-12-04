using System.Collections.Generic;
using System.Linq;

namespace ValidacaoCliente
{
    public static class ConcatenarDictionary
    {
        public static void Append<K, V>(this Dictionary<K, V> principal, Dictionary<K, V> adicionar)
        {
            List<KeyValuePair<K, V>> list = adicionar.ToList();
            list.ForEach(item => principal.Add(item.Key, item.Value));
        }
    }
}
