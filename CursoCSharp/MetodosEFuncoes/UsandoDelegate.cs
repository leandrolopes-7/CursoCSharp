using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.MetodosEFuncoes {
    class UsandoDelegate {

        delegate double Soma(double a, double b);
        delegate void ImprimirSoma(double a, double b);

        static double MinhaSoma(double x, double y) {
            return x + y;
        }

        static void MeuImprimirSoma(double a, double b) {
            Console.WriteLine(a + b);
        }
        public static void Executar() {
            Soma op1 = MinhaSoma;
            Console.WriteLine(op1(5, 9));

            ImprimirSoma op2 = MeuImprimirSoma;
            op2(7, 7);

            Func<double, double, double> op3 = MinhaSoma;
            Console.WriteLine(op3(9, 9));

            Action<double, double> op4 = MeuImprimirSoma;
            op4(4, 4);
        }
    }
}
