using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Colecoes
{
    class ColecoesDictionary
    {
        public static void Executar()
        {
            var filmes = new Dictionary<int, string>();

            filmes.Add(2002, "Godzilla");
            filmes.Add(2012, "Project-X");
            filmes.Add(2018, "Halloween");
            filmes.Add(2006, "No Fundo do Mar");

            if (filmes.ContainsKey(2018))
            {
                Console.WriteLine("2018: " + filmes[2018]);
                Console.WriteLine("2018: " + filmes.GetValueOrDefault(2018));
            }

            Console.WriteLine(filmes.ContainsValue("Amnésia"));

            Console.WriteLine($"Removeu? {filmes.Remove(2006)}");

            filmes.TryGetValue(2012, out string filme2012);
            Console.WriteLine($"Filme {filme2012}");

            foreach(var key in filmes.Keys)
            {
                Console.WriteLine(key);
            }

            foreach(var valor in filmes.Values)
            {
                Console.WriteLine(valor);
            }

            foreach(KeyValuePair<int, string> filme in filmes)
            {
                Console.WriteLine($"{filme.Value} é de {filme.Key}");
            }

            foreach(var filme in filmes)
            {
                Console.WriteLine($"{filme.Value} é de {filme.Key}");
            }
        }
    }
}
