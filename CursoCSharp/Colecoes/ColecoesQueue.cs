using System;
using System.Collections.Generic;
using System.Collections;

namespace CursoCSharp.Colecoes
{
    class ColecoesQueue
    {
        public static void Executar()
        {
            var fila = new Queue<string>();

            fila.Enqueue("Leandro");
            fila.Enqueue("Antonio");
            fila.Enqueue("Quiteria");
            fila.Enqueue("Mariana");

            Console.WriteLine(fila.Peek());
            Console.WriteLine(fila.Count);

            Console.WriteLine(fila.Dequeue());
            Console.WriteLine(fila.Count);

            foreach(var pessoa in fila)
            {
                Console.WriteLine(pessoa);
            }

            var salada = new Queue();
            salada.Enqueue("Banana");
            salada.Enqueue(4);
            salada.Enqueue(false);
            salada.Enqueue(3.14);

            Console.WriteLine(salada.Contains("banana"));
            Console.WriteLine(salada.Contains("Banana"));

        }
    }
}
