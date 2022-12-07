using System.Collections;

namespace RemoverRepetidos
{
    public static class RemoveRepetidosLista
    {
        public static void RemoveRepetidos(this IList lista)
        {
            for (int i = 0; i < lista.Count; i++)
            {
                for (int j = 0; j < lista.Count; j++)
                {
                    if (i != j)
                    {
                        if (lista[j].Equals(lista[i]))
                            lista.RemoveAt(j);
                    }
                }
            }
        }
    }
}
