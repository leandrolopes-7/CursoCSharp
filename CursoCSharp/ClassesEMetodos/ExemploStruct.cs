using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
    interface Ponto
    {
        void MoverNaDiagonal(int delta);
    }

    struct Coordenada: Ponto
    {
        public int X;
        public int Y;

        public Coordenada(int x, int y)
        {
            X = x;
            Y = y;
        }

        public void MoverNaDiagonal(int delta)
        {
            X += delta;
            Y += delta;
        }
    }
    class ExemploStruct
    {
        public static void Executar()
        {
            Coordenada coordenadaInicial;
            coordenadaInicial.X = 5;
            coordenadaInicial.Y = 5;

            Console.WriteLine("Cordenada Inicial:");
            Console.WriteLine("X = {0}",coordenadaInicial.X);
            Console.WriteLine("Y = {0}",coordenadaInicial.Y);

            var coordenadaFinal = new Coordenada(7, 9);
            coordenadaFinal.MoverNaDiagonal(10);

            Console.WriteLine("Coordenada Final:");
            Console.WriteLine("X = {0}",coordenadaFinal.X);
            Console.WriteLine("Y = {0}",coordenadaFinal.Y);
        }
    }
}
