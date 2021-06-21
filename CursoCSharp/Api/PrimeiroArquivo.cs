using System;
using System.IO;

namespace CursoCSharp.Api {
    class PrimeiroArquivo {
        public static void Executar() {
            var path = @"~/primeiro_arquivo.txt";

            if (!File.Exists(path)) {
                using (StreamWriter sw = File.CreateText(path)) {
                    sw.WriteLine("Esse é");
                    sw.WriteLine("o nosso");
                    sw.WriteLine("primeiro");
                    sw.WriteLine("arquivo!");
                }
            }
        }
    }
}