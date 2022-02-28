using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos {
    class ParametrosVariaveis {
        public static void Executar() {
            ProgramaParams.Params("Renanzera", "Sergera", "Brunera", "Marquera");
        }
    }

    class ProgramaParams {

        public static void Params(params string[] nomes) {
            foreach(var pessoa in nomes) {
                Console.WriteLine(pessoa);
            }
        }
    }
}
