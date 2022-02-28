using System;

namespace CursoCSharp.ClassesEMetodos {
    class EncadeamentoMetodos {
        public static void Executar() {
            var calcula = new Programa();

            Console.WriteLine(calcula.Somar(10).Subtrair(50).Imprimir());

        }
    }

    class Programa {
        int memoria;

        public Programa Somar(int a) {
            memoria += a;
            return this;
        }

        public Programa Subtrair(int a) {
            memoria -= a;
            return this;
        }

        public void ImprimirConsole() {
            Console.WriteLine($"Valor variavél {memoria}");
        }

        public int Imprimir() {
            return memoria;
        }
    }
}
