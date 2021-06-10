using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
    class CarroOpcional
    {
        double desconto = 0.1;
        string nome;

        public string Nome
        {
            get
            {
                return "Opcional: " + nome;
            }
            set
            {
                nome = value;
            }
        }

        //Propriedade Autoimplementada
        public double Preco { get; set; }

        public double PrecoComDesconto
        {
            get => Preco - Preco * desconto;
        }

        public CarroOpcional(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
        }

        public CarroOpcional()
        {

        }
    }
    class Props
    {
        public static void Executar()
        {
            var opcional1 = new CarroOpcional("Ar Condicionado", 3400.90);

            Console.WriteLine(opcional1.PrecoComDesconto);

            var opcional2 = new CarroOpcional();

            opcional2.Nome = "Direção Hidraulica";
            opcional2.Preco = 2400.90;

            Console.WriteLine(opcional1.Nome +" "+ opcional1.Preco +" "+opcional1.PrecoComDesconto);
            Console.WriteLine(opcional2.Nome +" "+ opcional2.Preco +" "+opcional2.PrecoComDesconto);

        }
    }
}
