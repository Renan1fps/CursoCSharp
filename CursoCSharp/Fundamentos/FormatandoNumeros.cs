using System;
using System.Globalization;

namespace CursoCSharp.Fundamentos {
    class FormatandoNumeros {
        public static void Executar() {
            double valor = 15.175;
            Console.WriteLine(valor.ToString("F1")); // arredonda o numero pós virgula 
            Console.WriteLine(valor.ToString("C"));  // formata para monetário(dinheiro) e arredonda pós virgula 
            Console.WriteLine(valor.ToString("P"));  // multilica por 100 e coloca o percentual
            Console.WriteLine(valor.ToString("#.##")); // arredonda com base na qauntidade de # que eu colocar

            CultureInfo culture = new CultureInfo("pt-BR"); // en-US <- ingles setando a "cultura" linguagem de sinais que o sistema usará
            Console.WriteLine(valor.ToString("C0", culture)); // imprimir o dinheiro sem nenhuma casa decimal e na cultura que quero
        }
    }
}
