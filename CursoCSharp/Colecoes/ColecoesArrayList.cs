using System;
using System.Collections;
using System.Text;

namespace CursoCSharp.Colecoes
{
    class ColecoesArrayList
    {
        public static void Executar()
        {
            var arrayList = new ArrayList
            {
                "LEandro",
                4,
                false
            };

            arrayList.Add(3.14);

            foreach(var item in arrayList)
            {
                Console.WriteLine($"{item} {item.GetType()}");
            }
        }
    }
}
