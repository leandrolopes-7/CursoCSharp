using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Colecoes
{
    
    class ColecoesSet
    {
        public static void Executar()
        {
            var livro = new Produto("Game of Thrones", 49.9);

            var carrinho = new HashSet<Produto>();
            carrinho.Add(livro);

            var combo = new HashSet<Produto>
            {
                new Produto("Dexter", 79.9),
                new Produto("Mente Milionaria", 39.9),
                new Produto("God of War", 89.9)
            };

            carrinho.UnionWith(combo);
            Console.WriteLine(carrinho.Count);
            //carrinho.RemoveAt(2);

            foreach(var item in carrinho)
            {
                //Console.Write(carrinho.IndexOf(item));
                Console.WriteLine($" {item.Nome } {item.Preco}");
            }

            Console.WriteLine(carrinho.Count);
            carrinho.Add(livro);
            Console.WriteLine(carrinho.Count);
            //Console.WriteLine(carrinho.LastIndexOf(livro));
        }
    }
}
