using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class VariaveisEConstantes
    {
        public static void Executar()
        {
            //area da circunferencia
            double raio = 4.5;
            const double PI = 3.14;

            raio = 5.5;
            //PI = 3.1415;

            double area = PI * raio * raio;
            Console.WriteLine(area);
            Console.WriteLine("Área é " +area);

            //Tipos internos
            bool estaChovendo = true;
            Console.WriteLine("Está chovendo " +estaChovendo);

            byte idade = 45;
            Console.WriteLine("Idade" +idade);

            sbyte saldoDeGols = sbyte.MinValue;
            Console.WriteLine("Saldo de Gols " +saldoDeGols);

            short salario = short.MaxValue;
            Console.WriteLine("Salario " +salario);

            int menorValorInt = int.MinValue; //Mais usado dos inteiros;
            Console.WriteLine("Menor valor inteiro" +menorValorInt);

            uint populacaoBrasileira = 207_600_000;
            Console.WriteLine("População Brasileira " +populacaoBrasileira);

            long menorValorLong = long.MinValue;
            Console.WriteLine("Menor Long " +menorValorLong);

            ulong populacaoMundial = 7_600_000_000;
            Console.WriteLine("População mundial " +populacaoMundial);

            float precoComputador = 1299.99f;
            Console.WriteLine("Preço do Computador " +precoComputador);

            double valorDeMercadoDaApple = 1_000_000_000_000.00;
            Console.WriteLine("Valor Mercado da Apple " +valorDeMercadoDaApple);

            decimal distanciaEntreEstrelas = decimal.MaxValue;
            Console.WriteLine("Distancia entre Estrelas " +distanciaEntreEstrelas);

            char letra = 'a';
            Console.WriteLine("Letra " +letra);

            string texto = "Seja Bem Vindo ao Curso de CSharp";
            Console.WriteLine(texto);
        }
    }
}
