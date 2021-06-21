using System;
using System.IO;

namespace CursoCSharp.Api {
    class LendoArquivos {
        public static void Executar() {
            var path = @"~/lendo_arquivos.txt".ParseHome();


            if (!File.Exists(path)) {
                using (StreamWriter sw = File.AppendText(path)) {
                    sw.WriteLine("Produto;Preco;Qtde");
                    sw.WriteLine("Caneta Bic Preta; 3,59;87");
                    sw.WriteLine("Borracha Branca; 2,89;22");
                }
            }

            try {
                using(StreamReader sr = new StreamReader(path)) {
                    var texto = sr.ReadToEnd();
                    Console.WriteLine(texto);
                }
            }catch(Exception ex) {
                Console.WriteLine(ex.Message);
            }
        }
    }
}