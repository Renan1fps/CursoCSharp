using System;

namespace CursoCSharp.Fundamentos {
    class Inferencia {
        public static void Executar() {
            // inferencia de tipos

            var nome = "renan"; // devo inicializar
            Console.WriteLine(nome);

            // nome = 123 // dá erro pois ela foi inicializada com um string

            var idade = 123;
            Console.WriteLine(idade);

            int a; //declarei 
            int b = 2; //declarei e inicializei


        }
    }
}
