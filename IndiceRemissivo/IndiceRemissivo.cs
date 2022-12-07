using System;
using System.Collections.Generic;

namespace IndiceRemissivo
{
    internal class IndiceRemissivo
    {
        private List<ContadorPalavra> palavras = new List<ContadorPalavra>();

        public List<String> texto { get; private set; }
        public List<String> textoIgnorar { get; private set; }

        public IndiceRemissivo(string pathTXT, string? pathIgnorar = null)
        {
            if (pathIgnorar != null)
                textoIgnorar = LerArquivo.LerArquivoIgnore(pathIgnorar);

            palavras = LerArquivo.LerArquivoLinha(pathTXT, textoIgnorar);
        }

        public void Imprime()
        {
            foreach (var item in palavras)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}
