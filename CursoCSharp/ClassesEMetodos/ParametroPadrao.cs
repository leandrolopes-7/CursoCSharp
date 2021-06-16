using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
    class ParametroPadrao
    {
        public static int Somar(int num1 = 2, int num2 = 2)
        {
            return num1 + num2;
        }
        public static void Executar()
        {
            Console.WriteLine(Somar(3, 5));
            Console.WriteLine(Somar(5));
            Console.WriteLine(Somar());
            Console.WriteLine(Somar(num2: 4));
        }
    }
}
