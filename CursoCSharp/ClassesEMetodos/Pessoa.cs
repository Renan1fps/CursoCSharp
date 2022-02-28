using System;

namespace CursoCSharp.ClassesEMetodos {
    class Pessoa {
        public string Nome;
        public int Idade;

        public string Apresentar() {
            return string.Format($"Olá meu nome é {Nome} e tenho {Idade} anos");
        }

        public void ApresentarConsole() {
            Console.WriteLine(Apresentar());
        }
    }
}
