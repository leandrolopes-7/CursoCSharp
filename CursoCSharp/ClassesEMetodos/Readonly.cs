using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
    class Cliente
    {
        public string Nome;
        public readonly DateTime Nascimento;

        public Cliente(string nome, DateTime nascimento)
        {
            Nome = nome;
            Nascimento = nascimento;
        }

        public string GetDataNascimento()
        {
            return string.Format("{0}/{1}/{2}", Nascimento.Day, Nascimento.Month, Nascimento.Year);
        }
    }
    class Readonly
    {
        public static void Executar()
        {
            var newCliente = new Cliente("Leandro", new DateTime(1996, 5, 22));

            Console.WriteLine(newCliente.Nome + " " + newCliente.GetDataNascimento());
            Console.WriteLine(newCliente.Nascimento);

        }
    }
}
