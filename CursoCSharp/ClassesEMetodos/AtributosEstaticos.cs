using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{

    class Produto
    {
        public string Nome;
        public double Preco;
        public static double Desconto;

       public Produto(string nome, double preco, double desconto)
        {
            Nome = nome;
            Preco = preco;
            Desconto = desconto;
        }

        public double CalcularDesconto()
        {
            return Preco - Preco * Desconto;
        }

        public Produto()
        {

        }
    }
    class AtributosEstaticos
    {
        public static void Executar()
        {
            Produto produto = new Produto("Caneta", 7.5, 0.1);

            Produto produto2 = new Produto()
            {
                Nome = "Borracha",
                Preco = 4.5
            };
            
            Console.WriteLine(produto.CalcularDesconto());
            Console.WriteLine(produto2.CalcularDesconto());

            Produto.Desconto = 0.5;

            Console.WriteLine(produto.CalcularDesconto());
            Console.WriteLine(produto2.CalcularDesconto());

        }
    }
}
