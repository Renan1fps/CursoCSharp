using System;
using System.Globalization;

namespace CursoCSharp.Fundamentos {
    class LendoDados {
        public static void Executar() {
            Console.Write("Qual seu nome?");
            string nome = Console.ReadLine();

            // dados do console sempre vem em string (preciso fazer o parse caso seja numero)
            Console.Write("Qual sua idade?");
            int idade = int.Parse(Console.ReadLine());

            Console.Write("Qual seu salário?");
            double salario = double.Parse(Console.ReadLine());
            // nesse caso como meu sistemas está em portugues tenho que usar , para separa valores

            // para contornar isso devemos usar o System.Globalization
            Console.Write("Qual seu salário?");
            double salarioComPonto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine($"o seu nome é {nome} e sua idade é {idade} e recebe R${salario}");
            Console.WriteLine($"Com POnto -> o seu nome é {nome} e sua idade é {idade} e recebe R${salarioComPonto}");

        }
    }
}
