using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
    class Carro
    {
        public string Fabricante;
        public string Modelo;
        public int Ano;

        public Carro(string fabricante, string modelo, int ano)
        {
            Fabricante = fabricante;
            Modelo = modelo;
            Ano = ano;
        }

        public Carro()
        {

        }
    }
    class Construtores
    {
        public static void Executar()
        {
            Carro carro1 = new Carro();
            carro1.Fabricante = "Volvo";
            carro1.Modelo = "V60";
            carro1.Ano = 2018;

            Console.WriteLine("{0} modelo {1} do ano {2}.", carro1.Fabricante, carro1.Modelo, carro1.Ano);

            var carro2 = new Carro("Ford", "Ka", 2020);

            Console.WriteLine("{0} modelo {1} do ano {2}.", carro2.Fabricante, carro2.Modelo, carro2.Ano);

            Carro carro3 = new Carro()
            {
                Fabricante = "Dodge",
                Modelo = "Dakota",
                Ano = 2002
            };
            Console.WriteLine("{0} modelo {1} do ano {2}.", carro3.Fabricante, carro3.Modelo, carro3.Ano);
          
        }
    }
}
