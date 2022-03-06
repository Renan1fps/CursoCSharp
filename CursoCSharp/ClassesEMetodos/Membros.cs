using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos {
    class Membros {
       public static void Executar() {
            Pessoa fulano = new Pessoa();
            fulano.Nome = "Renanzera";
            fulano.Idade = 21;
            fulano.ApresentarConsole(); // metodo da classe que apresenta infos
        }
    }
}
