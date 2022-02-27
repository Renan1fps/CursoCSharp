using System;

namespace CursoCSharp.EstruturaControle {
    class Exercicio {
        public static void Executar() {

            Console.Write("Digite seu nome: ");
            string nome = Console.ReadLine();

            Console.Write("Digite sua nota: ");
            int.TryParse(Console.ReadLine(), out int nota);

            if (nota >= 7) {
                Console.WriteLine($"{nome} você está aprovado!!");
            } else {
                Console.WriteLine($"{nome} você está reprovado!!");
            }
        }
    }
}
