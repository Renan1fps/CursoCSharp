using System;
using System.Collections.Generic;

using CursoCSharp.Fundamentos;
using CursoCSharp.EstruturaControle;
using CursoCSharp.ClassesEMetodos;

namespace CursoCSharp {
    class Program {
        static void Main(string[] args) {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {
                {"Primeiro Programa - Fundamentos", Primeiro.Executar},
                {"Comentarios Programa - Fundamentos", Comentarios.Executar},
                {"Variaveis e Constantes - Fundamentos", VariaveisEConstantes.Executar},
                {"Inferencia - Fundamentos", Inferencia.Executar},
                {"Interpolação - Fundamentos", Interpolacao.Executar},
                {"Notação ponto - Fundamentos", NotacaoPonto.Executar},
                {"Lendo Dados - Fundamentos", LendoDados.Executar},
                {"Formatando numeros - Fundamentos", FormatandoNumeros.Executar},
                {"Conversões - Fundamentos", Conversoes.Executar},

                // estruturas de controle
                {"Exercício Um - Estrutura de controle", Exercicio.Executar},
                {"Exercício Dois - Estrutura de controle", Exercicio2.Executar},
                {"Exercício Tres - Estrutura de controle", For.Executar},

                // classes e metodos
                {"Membros: Atributos e Métodos -Classes e metodos", Membros.Executar},
                {"Construtores -Classes e metodos", Contrutores.Executar},
                {"Metodos -Classes e metodos", Metodos.Executar},
                {"Encadeamento Metodos -Classes e metodos", EncadeamentoMetodos.Executar},
                {"Metodos Estáticos -Classes e metodos", MetodosEstaticos.Executar},
            });

            central.SelecionarEExecutar();
        }
    }
}