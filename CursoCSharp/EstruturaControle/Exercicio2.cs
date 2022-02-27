using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.EstruturaControle {
    class Exercicio2 {
        public static void Executar() {
            Random random = new Random();
            int tentativas = 0;
            int tentativasRestantes = 5;
            bool numeroEncontrado = false;
            int numeroSecreto = random.Next(1, 16);

            while(tentativasRestantes > 0 && !numeroEncontrado) {
                Console.WriteLine("Digite um número: ");
                int.TryParse(Console.ReadLine(), out int input);

                tentativas++;
                tentativasRestantes--;

                if(input == numeroSecreto) {
                    numeroEncontrado = true;
                    Console.WriteLine($"Parabéns número encontrado em {tentativas} tentativas !!");
                } else if (input > numeroSecreto) {
                    Console.WriteLine("Número digitado maior que o número secreto");
                    Console.WriteLine($"TENTATIVAS RESTANTES {tentativasRestantes}");
                } else {
                    Console.WriteLine("Número digitado menor que o número secreto");
                    Console.WriteLine($"TENTATIVAS RESTANTES {tentativasRestantes}");
                }
            }
        }
    }
}
