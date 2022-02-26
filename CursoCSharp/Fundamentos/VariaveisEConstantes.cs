using System;

namespace CursoCSharp.Fundamentos {
    class VariaveisEConstantes {
        public static void Executar() {
            double raio = 3.4;
            const double PI = 3.14;

            raio = 5.4;
            // concatenação em C#
            Console.WriteLine("O valor do raio é " + raio);

            double area = PI * raio * raio;
            Console.WriteLine("o valor da area é " + area);

            //concatenação com soma
            Console.WriteLine("o valor da area é " + (area + 100));

            bool isOpen = true;
            Console.WriteLine("está aberto" + isOpen);

            // int por padrão tem sinal (valor do valor positivo ao negativo)
            int valorInteiro = 100;
            Console.WriteLine("Valor gasolina" + valorInteiro);

            byte idade = 45;
            Console.WriteLine("Idade da pessoa " + idade);

            // algumas funçoes padores que já vem

            sbyte saldoDeGols = sbyte.MaxValue;
            Console.WriteLine("Saldo de gols é " + saldoDeGols);

            sbyte saldoDeGols2 = sbyte.MinValue;
            Console.WriteLine("Saldo de gols é " + saldoDeGols2);

            // int sem sinal (sempre positivo) não aceita negativo
            uint populacao = uint.MaxValue;
            Console.WriteLine("População brasileira " + populacao);

            // float tenho que usar f no final,m mas preferencialmente usar double
            float precoComputador = 1200.00f;
            Console.WriteLine("Preço do computador " + precoComputador);

            char letra = 'r';
            Console.WriteLine("Usando char" + letra);

            string palavra = "renan";
            Console.WriteLine("Usando string" + palavra);


        }
    }
}
