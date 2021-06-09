using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
    class CalculadoraComum
    {
        public int Somar(int a, int b)
        {
            return a + b;
        }

        public int Subtrair(int a, int b)
        {
            return a - b;
        }

        public int Multiplicar(int a, int b)
        {
            return a * b;
        }

        public int Dividir(int a, int b){
            return a / b;
        }
    }

    class CalculadoraCadeia
    {
        int memoria;

        public CalculadoraCadeia Somar(int a)
        {
            memoria += a;
            return this;
        }

        public CalculadoraCadeia Subtrair(int a)
        {
            memoria -= a;
            return this;
        }

        public CalculadoraCadeia Multiplicar(int a)
        {
            memoria *= a;
            return this;
        }

        public CalculadoraCadeia Dividir(int a)
        {
            memoria /= a;
            return this;
        }

        public CalculadoraCadeia Limpar()
        {
            memoria = 0;
            return this;
        }

        public CalculadoraCadeia Imprimir()
        {
            Console.WriteLine(memoria);
            return this;
        }

        public int Resultado()
        {
            return memoria;
        }
    }
    class MetodosComRetorno
    {
        public static void Executar()
        {
            Console.WriteLine("Digite o primeiro numero: ");
            int.TryParse(Console.ReadLine(), out int a);

            Console.WriteLine("Digite o segundo numero: ");
            int.TryParse(Console.ReadLine(), out int b);

            var calculadoraComum = new CalculadoraComum();
            Console.WriteLine(calculadoraComum.Somar(a, b));
            Console.WriteLine(calculadoraComum.Subtrair(a, b));
            Console.WriteLine(calculadoraComum.Dividir(a, b));
            Console.WriteLine(calculadoraComum.Multiplicar(a, b));

            var calculadoraCadeia = new CalculadoraCadeia();

            Console.WriteLine();
            calculadoraCadeia.Somar(5).Subtrair(1).Multiplicar(4).Imprimir().Limpar().Imprimir();
        }
    }
}
