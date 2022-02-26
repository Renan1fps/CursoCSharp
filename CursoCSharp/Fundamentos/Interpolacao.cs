using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos {
    class Interpolacao {
        public static void Executar() {
            string nome = "Notebook gamer";
            string marca = "Dell";
            double preco = 4500.55;

            Console.WriteLine($"O {nome} da {marca} é muito bom e custa {preco}");
            Console.WriteLine("Outra forma -> o {0} da {1} é muito bom e custa {2}", nome, marca, preco);
            Console.WriteLine($"Soma -> 1+1 = {1 + 1}");
        }
    }
}
