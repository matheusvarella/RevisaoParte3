using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace IndiceRemissivo
{
    public static class LerArquivo
    {
        public static List<string> LerArquivoIgnore(string path)
        {
            try
            {
                var linhasTXT = File.ReadAllText(path);
                string txt = Regex.Replace(linhasTXT, @"[^\w@-]", " ");
                txt = Regex.Replace(txt, @"[\-]", " ");

                string[] txtarray = txt.Split(" ");

                var lista = new List<string>();

                foreach (var item in txtarray)
                {
                    if (item.Length > 0 && item != " " && item != "\n")
                    {
                        lista.Add(item);
                    }
                }

                return lista;
            }
            catch
            {
                throw new IOException("Não foi possível ler o arquivo");
            }
        }

        public static List<ContadorPalavra> LerArquivoLinha(string path, List<string>? textoIgnorar = null)
        {
            try
            {
                var linhasTXT = File.ReadAllLines(path);
                var contador = new List<ContadorPalavra>();

                for (int i = 0; i < linhasTXT.Length; i++)
                {
                    var linha = LerLinha(linhasTXT[i]);
                
                    for (int j = 0; j < linha.Length; j++)
                    {
                        if (textoIgnorar != null)
                        {
                            if (!textoIgnorar.Contains(linha[i]))
                            {
                                if (!ContadorContemPalavra(contador, linha[i]))
                                {
                                    contador.Add(new ContadorPalavra(linha[i], i + 1));
                                } 
                                else
                                {
                                    var aux = contador.First(x => x.Palavra == linha[i]);
                                    aux.AdicionarLinha(i + 1);
                                }
                            }
                        }

                    }
                }

                return contador;
            }
            catch
            {
                throw new IOException("Não foi possível ler o arquivo");
            }
        }

        private static string[] LerLinha(string linha)
        {
            string caracteres = ". , ; < > : \\ / | ~ ^ ´ ` [ ] { } ‘ “ ! @ # $ % & * ( ) _ + =";

            char[] chars = caracteres.ToCharArray();
            
            var palavras = linha.Split(chars);

            return palavras;

            for (int i = 0; i <= palavras.Length; i++)
            {

            }
        }

        private static bool ContadorContemPalavra(List<ContadorPalavra> contador, string palavra)
        {
            var resultado = false;

            foreach (var item in contador)
            {
                if (item.Palavra == palavra)
                {
                    resultado = true;
                    break;
                }
            }

            return resultado;
        }
    }
}
