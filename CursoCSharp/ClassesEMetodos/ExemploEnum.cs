using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
    enum Genero { Acao, Comedia, Romance, Terror, Suspense};

    class Filme
    {
        public string Titulo;
        public Genero GeneroFilme;
    }

    class ExemploEnum
    {
        public static void Executar()
        {
            int id = (int) Genero.Acao;
            Console.WriteLine(id);

            var filme1 = new Filme();
            filme1.Titulo = "Invocação do Mal";
            filme1.GeneroFilme = Genero.Terror;

            Console.WriteLine("O filme {0} é de {1}", filme1.Titulo, filme1.GeneroFilme);

        }
    }
}
