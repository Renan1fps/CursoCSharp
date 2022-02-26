using System;
using System.Collections.Generic;

using CursoCSharp.Fundamentos;

namespace CursoCSharp {
    class Program {
        static void Main(string[] args) {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {
                {"Primeiro Programa - Fundamentos", Primeiro.Executar},
                {"Comentarios Programa - Fundamentos", Comentarios.Executar},
            });

            central.SelecionarEExecutar();
        }
    }
}