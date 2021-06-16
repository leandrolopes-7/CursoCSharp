using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Colecoes
{
    class Igualdade
    {
        public static void Executar()
        {
            var p1 = new Produto("Caneta", 1.5);
            var p2 = new Produto("Caneta", 1.5);

            Console.WriteLine(p1 == p2);
            Console.WriteLine(p1.Equals(p2));
        }
    }
}
