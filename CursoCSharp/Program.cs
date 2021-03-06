using System;
using System.Collections.Generic;

using CursoCSharp.Fundamentos;
using CursoCSharp.EstruturasDeControle;
using CursoCSharp.ClassesEMetodos;
using CursoCSharp.Colecoes;
using CursoCSharp.OO;
using CursoCSharp.MetodosEFuncoes;
using CursoCSharp.Excecoes;
using CursoCSharp.Api;
using CursoCSharp.TopicosAvancados;

namespace CursoCSharp {
    class Program {
        static void Main(string[] args) {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {
                //Fundamentos
                {"Primeiro Programa - Fundamentos", PrimeiroPrograma.Executar},
                {"Comentarios - Fundamentos", Comentarios.Executar},
                {"Variaveis e Constantes - Fundamentos", VariaveisEConstantes.Executar },
                {"Inferencia - Fundamentos", Inferencia.Executar },
                {"Interpolação - Fundamentos", Interpolacao.Executar },
                {"Notação Ponto - Fundamentos", NotacaoPonto.Executar },
                {"Lendo Dados - Fundamentos", LendoDados.Executar },
                {"Formatando Numero - Fundamentos", FormatandoNumero.Executar },
                {"Conversões - Fundamentos", Conversoes.Executar },
                {"Operadores Aritméticos - Fundamentos", OperadoresAritmeticos.Executar },
                {"Operadores Relacionais - Fundamentos", OperadoresRelacionais.Executar },
                {"Operadores Lógicos - Fundamentos", OperadoresLogicos.Executar },
                {"Operadores de Atribuição - Fundamentos", OperadoresAtribuicao.Executar },
                {"Operadores Unários - Fundamentos", OperadoresUnarios.Executar },
                {"Operador Ternário - Fundamentos", OperadorTernario.Executar },
               
                //Estruturas de Controle
                {"Estrutura IF - Estruturas de Controle", EstruturaIf.Executar },
                {"Estrutura IF/ELSE - Estruturas de Controle", EstruturaIfElse.Executar },
                {"Estrutura IF/ELSE IF - Estruturas de Controle", EstruturaIfElseIf.Executar },
                {"Estrutura Switch - Estruturas de Controle", EstruturaSwitch.Executar },
                {"Estrutura While - Estruturas de Controle", EstruturaWhile.Executar },
                {"Estrutura Do While - Estruturas de Controle", EstruturaDoWhile.Executar },
                {"Estrutura For - Estruturas de Controle", EstruturaFor.Executar },
                {"Estrutura ForEach - Estruturas de Controle", EstruturaForEach.Executar },
                {"Usando Break - Estruturas de Controle", UsandoBreak.Executar },
                {"Usando Continue - Estruturas de Controle", UsandoContinue.Executar },
               
                //Classes e Metodos
                {"Membros - Classes e Metodos", Membros.Executar },
                {"Construtores - Classes e Metodos", Construtores.Executar },
                {"Metodos com Retorno - Classes e Metodos", MetodosComRetorno.Executar },
                {"Metodos Estáticos - Classes e Métodos", MetodosEstaticos.Executar },
                {"Atributos Estáticos - Classes e Métodos", AtributosEstaticos.Executar },
                {"Desafio Atributo - Classes e Métodos", DesafioAtributo.Executar },
                {"Params - Classes e Métodos", Params.Executar },
                {"Parametros Nomeados - Classes e Métodos", ParametrosNomeados.Executar },
                {"Get e Set - Classes e Métodos", GetSet.Executar },
                {"Props - Classes e Métodos", Props.Executar },
                {"Readonly - Classes e Métodos", Readonly.Executar },
                {"Exemplo Enum - Classes e Métodos", ExemploEnum.Executar },
                {"Exemplo Struct - Classes e Métodos", ExemploStruct.Executar },
                {"Struct VS Class - Classes e Métodos", StructVsClass.Executar },
                {"Valor vs Referencia - Classes e Métodos", ValorVsReferencia.Executar },
                {"Parametros por Referencia - Classes e Métodos", ParametrosPorReferencia.Executar },
                {"Parametro Padrão - Classes e Métodos", ParametroPadrao.Executar },

                //Coleções
                {"Usando Array - Coleções", UsandoArray.Executar },
                {"List - Coleções", ColecoesList.Executar },
                {"ArrayList - Coleções", ColecoesArrayList.Executar },
                {"Set - Coleções", ColecoesSet.Executar },
                {"Queue - Coleções", ColecoesQueue.Executar },
                {"Igualdade - Coleções", Igualdade.Executar},
                {"Stack - Coleções", ColecoesStack.Executar },
                {"Dictionary - Coleções", ColecoesDictionary.Executar },
                
                //OO
                {"Herança - Orientação a Objeto",Heranca.Executar  },
                {"Constructor This - Orientação a Objeto",ConstructorThis.Executar  },
                {"Encapsulamento - Orientação a Objeto", OO.Encapsulamento.Executar },
                {"Polimorfismo - Orientação a Objeto", Polimorfismo.Executar },
                {"Abstract - Orientação a Objeto", Abstract.Executar },
                {"Interface - Orientação a Objeto", Interface.Executar },
                {"Sealed - Orientação a Objeto", Sealed.Executar },

                //Métodos e Funções
                {"Exemplo Lambda - Métodos e Funções", ExemploLambda.Executar },
                {"Lamba com Delegate - Métodos e Funções", LambdasDelegate.Executar },
                {"Usando Delegate - Métodos e Funções", UsandoDelegate.Executar },
                {"Delegate com Func Anonimas - Métodos e Funções", DelegateFuncAnonima.Executar },
                {"Delegates como parametros - Métodos e Funções", DelegatesComoParametros.Executar },
                {"Metodos de Extensão - Métodos e Funções", MetodosDeExtensao.Executar },

                //Exceções
                {"Primeira Exceção - Exceções", PrimeiraExcecao.Executar },
                {"Exceções Personalizadas - Exceções", ExcecoesPersonalizadas.Executar },

                //Explorando API
                {"Primeiro Arquivo - Explorando API", PrimeiroArquivo.Executar },
                {"Lendo Arquivos - Explorando API", LendoArquivos.Executar },
                {"Exemplo File Info - Explorando API", ExemploFileInfo.Executar },
                {"Diretorios - Explorando API", Diretorios.Executar },
                {"Exemplos DirectoryInfo - Explorando API", ExemploDirectoryInfo.Executar },
                {"Exemplos Path - Explorando API", ExemploPath.Executar },
                {"Exemplos DateTime - Explorando API", ExemploDateTime.Executar },
                {"Exemplos TimeSpan - Explorando API", ExemploTimeSpan.Executar },

                //Tópicos Avançados
                {"LINQ #01 - Tópicos Avançados", LINQ1.Executar },
                {"LINQ #02 - Tópicos Avançados", LINQ2.Executar },
            });


            central.SelecionarEExecutar();
        }
    }
}