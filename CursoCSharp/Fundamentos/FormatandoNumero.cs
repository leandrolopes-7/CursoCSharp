using System;
using System.Globalization;

namespace CursoCSharp.Fundamentos
{
    class FormatandoNumero
    {
        public static void Executar()
        {
            double valor = 15.175;
            Console.WriteLine(valor.ToString("F1")); //uma casa decimal
            Console.WriteLine(valor.ToString("C")); //valor monetario
            Console.WriteLine(valor.ToString("P")); //percentual
            Console.WriteLine(valor.ToString("#.##")); //formatacao especifica de casas decimais

            CultureInfo cultura = new CultureInfo("en-US"); //formatacao para cultura
            Console.WriteLine(valor.ToString("C2", cultura));//valor monetario com casa decimal

            int inteiro = 256;
            Console.WriteLine(inteiro.ToString("D10"));
        }
    }
}
