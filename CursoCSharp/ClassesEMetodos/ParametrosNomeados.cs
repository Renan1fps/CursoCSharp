using System;

namespace CursoCSharp.ClassesEMetodos {
    class ParametrosNomeados {
        public static void Executar() {
            // Aqui eu inverti a ordem em que é espetado no metodo, mas estou nomeando para que independa da ordem
            Console.WriteLine(ProgramaNomeados.AnoFormacao(ano: 2023, dia: 12, mes: 12));
        }
    }

    class ProgramaNomeados {
        public static string AnoFormacao(int dia, int mes, int ano) {
            return string.Format($"o dia da formação foi {dia} no mês {mes} no ano de {ano}");
        }
    }
}
