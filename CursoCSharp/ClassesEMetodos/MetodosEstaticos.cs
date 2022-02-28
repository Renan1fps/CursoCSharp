using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos {
    class MetodosEstaticos {
        public static void Executar() {

            // exemplo estático: Pode ser acessado sem a necessidade de instanciar uma classe
            var resultado = ProgramaEstatico.Soma(8);
            Console.WriteLine(resultado);

            // aqui o metodo SomaSemEstatico só acessado depois de instaciar uma classe
            var resultado2 = new ProgramaEstatico();
            var resultadoOperacao = resultado2.SomaSemEstatico(8);
            Console.WriteLine(resultadoOperacao);

            // OBS* um membro estático não pode ser acessado com a instancia de uma classe, só podemos acessar se for estatico
        }
    }

    class ProgramaEstatico {

        public static int Soma(int a) {
            return a + 1;
        }

        public int SomaSemEstatico(int a) {
            return a + 5;
        }
    }
}
