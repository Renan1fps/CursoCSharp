namespace CursoCSharp.ClassesEMetodos {
    class MetodosComRetorno {

        public int SomarInteiros(int a, int b) {
            return a + b;
        }

        public double SomarDoubles(double a, double b) {
            return a + b;
        }

        public double SubtrairNumeros(int a, int b) {
            return a - b;
        }
    }

    class Metodos {
        public static void Executar() {
            var metodos = new MetodosComRetorno();

            System.Console.WriteLine(metodos.SomarInteiros(20, 10));
            System.Console.WriteLine(metodos.SomarDoubles(20.0, 15.5));
        }
    }
}
