using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Colecoes
{
    class UsandoArray
    {
        public static void Executar()
        {
            string[] alunos = new string[5];

            alunos[0] = "Leandro";
            alunos[1] = "Mariana";
            alunos[2] = "Quiteria";
            alunos[3] = "Antonio";
            alunos[4] = "Theodora";

            foreach(var aluno in alunos)
            {
                Console.WriteLine(aluno);
            }

            double[] notas = { 4.5, 6.9, 4.7, 9.4, 9.8, 8.8 };
            double somatorio = 0;

            foreach(var nota in notas)
            {
                somatorio += nota;
            }

            double media = somatorio / notas.Length;
            Console.WriteLine(media);

            char[] letras = { 'a', 'r', 'r', 'a', 'y' };
            string palavra = new string(letras);

            Console.WriteLine(palavra);
        }
    }
}
