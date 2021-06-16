using System;
using System.Collections;
using System.Text;

namespace CursoCSharp.Colecoes
{
    class ColecoesStack
    {
        public static void Executar()
        {
            var pilha = new Stack();

            pilha.Push("ola");
            pilha.Push(4);
            pilha.Push(true);
            pilha.Push(4.17f);

            foreach(var item in pilha)
            {
                Console.Write($"{item} ");
            }

            Console.WriteLine("\n",pilha.Pop());

            Console.WriteLine(pilha.Peek());
            Console.WriteLine(pilha.Count);
        }
    }
}
