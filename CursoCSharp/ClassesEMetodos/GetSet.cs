using System;

namespace CursoCSharp.ClassesEMetodos {
    class GetSet {
        public static void Executar() {
            var user = new ProgramaGetSet(email: "renanzera@gmail.com", senha: "c$p1v$r$*145872");
            Console.WriteLine(user.RetornaUsuario());

            var user2 = new ProgramaGetSet();
            user2.SetEmail("");
            user2.SetSenha("c$p1v$r$*145872");
            Console.WriteLine(user2.RetornaUsuario());

            Console.WriteLine($"Email do usuário {user2.GetEmail()}");
            Console.WriteLine($"Senha do usuário {user2.GetSenha()}");
        }
    }

    class ProgramaGetSet {

        private string Senha;
        private string Email;


        public ProgramaGetSet(string senha, string email) {
            this.Senha = senha;
            this.Email = email.ToLower();

            // outra forma de fazer atribuição
            // SetSenha(senha);
            // SetEmail(email);
        }

        public ProgramaGetSet() { }

        public string RetornaUsuario() {
            return string.Format($"Seu email é {this.Email} e sua senha é {this.Senha}");
        }

        public string GetSenha() {
            return this.Senha;
        }

        public void SetSenha(string senha) {
            this.Senha = senha;
        }

        public string GetEmail() {
            return this.Email;
        }

        public void SetEmail(string email) {
            // posso fazer validaçlões antes de atribuir
            if (email == "") {
                this.Email = "email@default";
            } else {
                this.Email = email;
            }
        }
    }
}
