namespace Jogador
{
    class Program
    {
        class Jogador
        {
            public string? nome;
            public string? posicao;
            public string? dataNascimentoStr;
            public string? nacionalidade;
            public int? altura;
            public double? peso;
            public int idade;

            public void imprimeDados()
            {
                Console.WriteLine($"Nome: {nome}");
                Console.WriteLine($"Posição: {posicao}");
                Console.WriteLine($"Data de Nascimento: {dataNascimentoStr} ");
                Console.WriteLine($"Nacionalidade: {nacionalidade}");
                Console.WriteLine($"Altura: {altura}cm");
                Console.WriteLine($"Peso: {peso}kg");
            }

            public int calcularIdade()
            {
                var dataNascimento = dataNascimentoStr?.Split("/");

                idade = DateTime.Now.Year - int.Parse(dataNascimento[2]);
                if (DateTime.Now.DayOfYear < int.Parse(dataNascimento[0]))
                {
                    idade--;
                }
                return idade;
            }

            public void calculaAposentadoria()
            {
                switch (posicao)
                {
                    case "defesa":
                        Console.WriteLine(
                            idade >= 40
                                ? "Já pode se aposentar"
                                : $"Faltam {40 - idade} para se aposentar"
                        );
                        break;
                    case "meio-campo":
                        Console.WriteLine(
                            idade >= 38
                                ? "Já pode se aposentar"
                                : $"Faltam {38 - idade} para se aposentar"
                        );
                        break;
                    case "atacante":
                        Console.WriteLine(
                            idade >= 35
                                ? "Já pode se aposentar"
                                : $"Faltam {35 - idade} para se aposentar"
                        );
                        break;
                }
            }
        }

        public static void CriaJogador(string[] args)
        {
            Jogador jogador1 = new Jogador();
            jogador1.nome = "João";
            jogador1.posicao = "defesa";
            jogador1.dataNascimentoStr = "19/08/2020";
            jogador1.nacionalidade = "brasileiro";
            jogador1.altura = 170;
            jogador1.peso = 80.5;

            jogador1.calcularIdade();

            jogador1.imprimeDados();

            jogador1.calculaAposentadoria();
        }
    }
}
