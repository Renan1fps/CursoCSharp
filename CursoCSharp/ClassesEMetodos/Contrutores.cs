namespace CursoCSharp.ClassesEMetodos {
    class Contrutores {
        public static void Executar() {
            var carro = new Carro(2017, "lancer", "mitsubishi");
            System.Console.WriteLine($"infos carro: nome: {carro.Nome}, marca: {carro.Marca}, ano: {carro.Ano}");
        }
    }

    class Carro {
        public int Ano;
        public string Nome;
        public string Marca;

        public Carro(int ano, string nome, string marca) {
            this.Ano = ano;
            this.Nome = nome;
            this.Marca = marca;
        }

        public Carro() { }
    }
}
