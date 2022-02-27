using System;

namespace CursoCSharp.Fundamentos {
    class Conversoes {
        public static void Executar() {
            // conversão implicita
            int inteiro = 10;
            double quebrado = inteiro;
            Console.WriteLine(quebrado);

            // conversão explicita
            double notaAluno = 9.7;
            int final = (int)notaAluno;

            Console.WriteLine("Digite sua idade: ");
            string valor = Console.ReadLine();
            int parseDoValor = int.Parse(valor);

            // nesse caso vai tentar realizar o parse se for um numero retorna ele, senão retorna zero
            Console.WriteLine("Digite um numero:");
            int.TryParse(Console.ReadLine(), out int parseado);
            Console.WriteLine("O valor parseado é -> {0}", parseado);
        }
    }
}
