using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos {
    class NotacaoPonto {
        public static void Executar() {
            string frase = " olá ".ToUpper().TrimStart().Insert(3, "mundo ").TrimEnd().Replace("mundo", "C#");
            //funçoes padrões para o tipo string
            Console.WriteLine(frase);

            // nesse caso o length não é uma função
            Console.WriteLine(frase.Length);

            //temos o caso em que podemos ter o dado vazio, então usamos a operação segura:
            string teste = null;
            Console.WriteLine(teste?.Length);
        }
    }
}
