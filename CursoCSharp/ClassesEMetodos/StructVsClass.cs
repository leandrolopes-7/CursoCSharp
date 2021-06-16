using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
    public struct SPonto
    {
        public int X;
        public int Y;
    }

    public class CPonto
    {
        public int X;
        public int Y;
    }
    class StructVsClass
    {
        public static void Executar()
        {
            SPonto ponto1 = new SPonto { X = 5, Y = 5 };
            SPonto copiaPonto1 = ponto1;
            ponto1.X = 7;

            Console.WriteLine("Ponto 1: {0}", ponto1.X);
            Console.WriteLine("Copi do ponto 1: {0}", copiaPonto1.X);

            CPonto ponto2 = new CPonto { X = 7, Y = 7 };
            CPonto copiaPonto2 = ponto2;
            ponto2.X = 9;

            Console.WriteLine("Ponto 2: {0}", ponto2.X);
            Console.WriteLine("Copia do ponto 2: {0}", copiaPonto2.X);
        }
    }
}
