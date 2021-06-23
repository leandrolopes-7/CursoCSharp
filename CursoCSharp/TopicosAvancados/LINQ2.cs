using System;
using System.Collections.Generic;
using System.Linq;

namespace CursoCSharp.TopicosAvancados {
    class LINQ2 {
        public static void Executar() {
            var alunos = new List<Aluno> {
                new Aluno(){Nome = "Leandro", Idade = 25, Nota = 9.7},
                new Aluno(){Nome = "Quiteria", Idade = 55, Nota = 9.9},
                new Aluno(){Nome = "Mariana", Idade = 20, Nota = 6.8},
                new Aluno(){Nome = "Antonio", Idade = 62, Nota = 7.5},
                new Aluno(){Nome = "Maria Eduarda", Idade = 12, Nota = 5.2},
                new Aluno(){Nome = "Catira", Idade = 23, Nota = 8.7}
            };

            var leandro = alunos.Single(aluno => aluno.Nome.Equals("Leandro"));
            Console.WriteLine($"{leandro.Nome} {leandro.Nota}");

            var fulano = alunos.SingleOrDefault(aluno => aluno.Nome.Equals("Fulano"));
            if(fulano == null) {
                Console.WriteLine("Aluno inexistente!");
            }

            var catira = alunos.First(aluno => aluno.Nome.Equals("Catira"));
            Console.WriteLine(catira.Nota);

            var sicrano = alunos.FirstOrDefault(aluno => aluno.Nome.Equals("Sicrano"));
            if(sicrano == null) {
                Console.WriteLine("Aluno Inexistente");
            }

            var quiteria = alunos.LastOrDefault(aluno => aluno.Nome.Equals("Quiteria"));
            Console.WriteLine(quiteria.Nota);

            var exemploSkip = alunos.Skip(1).Take(3);
            foreach(var item in exemploSkip) {
                Console.WriteLine(item.Nome);
            }

            var maiorNota = alunos.Max(aluno => aluno.Nota);
            Console.WriteLine(maiorNota);

            var menorNota = alunos.Min(aluno => aluno.Nota);
            Console.WriteLine(menorNota);

            var somatorioNotas = alunos.Sum(aluno => aluno.Nota);
            Console.WriteLine(somatorioNotas);

            var mediaNotas = alunos.Average(aluno => aluno.Nota);
            Console.WriteLine(mediaNotas);
        }
    }
}
