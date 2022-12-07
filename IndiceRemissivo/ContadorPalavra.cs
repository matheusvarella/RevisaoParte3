using System.Collections.Generic;

namespace IndiceRemissivo
{
    public class ContadorPalavra
    {
        public string Palavra { get; private set; }
        public int Quantidade { get; private set; }
        public List<int> Linhas { get; private set; }

        public ContadorPalavra(string palavra, int linha)
        {
            Palavra = palavra;
            Linhas = new List<int>();

            AdicionarLinha(linha);
        }

        public void AdicionarLinha(int linha) 
        {
            if (!Linhas.Contains(linha))
                Linhas.Add(linha);

            Quantidade++;
        }

        public override string ToString()
        {
            var exibir = Palavra + "(" + Quantidade + ") ";

            for (int i = 0; i < Linhas.Count; i++)
            {
                exibir+= Linhas[i].ToString();
                if (i < Linhas.Count - 1)
                    exibir += ", ";
            }

            return exibir;
        }
    }
}
