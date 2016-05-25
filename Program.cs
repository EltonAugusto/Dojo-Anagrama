using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anagramas
{
    public class Program
    {

        public static List<String> anagramas = new List<String>();
        public static char[] anagrama;

        static void Main(string[] args)
        { 
           

            var palavra = "RAFAEL";
            anagrama = new char[palavra.Length];

            criarAnagrama(palavra.ToArray(), palavra.Length, 0);

            Console.WriteLine(anagramas.Count());


        }



        private static void criarAnagrama(char[] palavra, int tamanho, int posicao)
        {

            for (int contador = 0; contador < tamanho; contador++)
            {
                
                anagrama[posicao] = palavra[contador];

                var bkp = palavra[0];
                palavra[0] = palavra[contador];
                palavra[contador] = bkp;

                var novaPalavra = String.Join(string.Empty, palavra).Substring(1).ToArray();
                criarAnagrama(novaPalavra, novaPalavra.Length, posicao + 1);

                
            }

            if (tamanho == 1)
            {
                anagramas.Add(String.Join(string.Empty, anagrama));
                Console.WriteLine("Novo anagrama: " + String.Join(string.Empty, anagrama));
                return;
            }
        }
    }
}
