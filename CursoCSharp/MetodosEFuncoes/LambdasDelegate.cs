using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.MetodosEFuncoes {

    delegate double Operacao(double x, double y);
    class LambdasDelegate {
        public static void Executar() {

            Operacao soma = (x, y) => x + y;
            Operacao subt = (x, y) => x - y;
            Operacao Mult = (x, y) => x * y;

            Console.WriteLine(soma(5, 5));
            Console.WriteLine(subt(10, 5));
            Console.WriteLine(Mult(5, 5));
        }
    }
}
