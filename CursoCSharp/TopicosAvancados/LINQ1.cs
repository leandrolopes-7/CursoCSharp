using System;
using System.Collections.Generic;
using System.Linq;

namespace CursoCSharp.TopicosAvancados {

    public class Aluno {
        public string Nome;
        public int Idade;
        public double Nota;
    }
    class LINQ1 {
        public static void Executar() {

            var alunos = new List<Aluno> {
                new Aluno(){Nome = "Leandro", Idade = 25, Nota = 9.7},
                new Aluno(){Nome = "Quiteria", Idade = 55, Nota = 9.9},
                new Aluno(){Nome = "Mariana", Idade = 20, Nota = 6.8},
                new Aluno(){Nome = "Antonio", Idade = 62, Nota = 7.5},
                new Aluno(){Nome = "Maria Eduarda", Idade = 12, Nota = 5.2},
                new Aluno(){Nome = "Catira", Idade = 23, Nota = 8.7}
            };

            Console.WriteLine("== Aprovados ===============");
            var aprovados = alunos.Where(a => a.Nota >= 7).OrderBy(a => a.Nome);
            foreach(var aluno in aprovados) {
                Console.WriteLine(aluno.Nome);
            }

            Console.WriteLine("\n== Chamada ===============");
            var chamada = alunos.OrderBy(a => a.Nome).Select(a => a.Nome);
            foreach(var aluno in chamada) {
                Console.WriteLine(aluno);
            }

            Console.WriteLine("\n== Aprovados (por idade)=================");
            var alunosAprovados =
                from aluno in alunos
                where aluno.Nota > 7
                orderby aluno.Idade
                select aluno.Nome;
            foreach(var aluno in alunosAprovados) {
                Console.WriteLine(aluno);
            }
        }
    }
}
