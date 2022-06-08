namespace Retangulos
{
    public class Retangulo
    {
        public double? altura;
        public double? largura;

        public void imprimeDados()
        {
            Console.WriteLine($"Altura: {altura}");
            Console.WriteLine($"Largura: {largura}");
        }
    }

    public static void Main(string[] args)
    {
        
        Retangulo retangulo = new Retangulo();
        Console.WriteLine("Digite a altura do retangulo: ");
        retangulo[1].altura = double.Parse(Console.ReadLine()!);

        Console.WriteLine("Digite a largura do retangulo: ");
        retangulo[1].largura = double.Parse(Console.ReadLine()!);

        retangulo.imprimeDados();
    }
}
