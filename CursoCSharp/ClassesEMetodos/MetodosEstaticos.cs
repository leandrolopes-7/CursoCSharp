using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
    class CalculadoraEstatica
    {   //Metodo acessado pela Classe, estático
        public static int Somar(int a, int b)
        {
            return a + b;
        }

        //Método acessado pela instancia
        public int Subtrair(int a, int b)
        {
            return a - b;
        }
    }
    class MetodosEstaticos
    {

        public static void Executar()
        {
            CalculadoraEstatica calc = new CalculadoraEstatica();
            Console.WriteLine(calc.Subtrair(5, 3));

            Console.WriteLine(CalculadoraEstatica.Somar(5, 5));
        }
    }
}
