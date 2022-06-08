namespace Calculadora
{
    internal class Program
    {
        class Calculadora
        {
            public double resultado;

            public double Soma(double numA, double numB)
            {
                return this.resultado = numA + numB;
            }

            public double Subtrai(double numA, double numB)
            {
                return this.resultado = numA - numB;
            }

            public double Divide(double numA, double numB)
            {
                return this.resultado = numA / numB;
            }

            public double Multiplica(double numA, double numB)
            {
                return this.resultado = numA * numB;
            }

            public double Potencia(double numA, double numB)
            {
                return this.resultado = Math.Pow(numA, numB);
            }
        }

        private static void Calcula(string[] args)
        {
            Calculadora teste = new Calculadora();

            Console.WriteLine("Digite o primeiro numero: ");
            double numA = double.Parse(Console.ReadLine()!);

            Console.WriteLine("Digite o segundo numero: ");
            double numB = double.Parse(Console.ReadLine()!);

            Console.WriteLine($"Qual operação deseja realizar?");
            Console.WriteLine(
                "1 - Soma \r\n2 - Subtração \r\n3 - Divisão \r\n4 - Multiplicação \r\n5 - Potência"
            );
            int operacao = int.Parse(Console.ReadLine()!);
            switch (operacao)
            {
                case 1:
                    teste.Soma(numA, numB);
                    break;
                case 2:
                    teste.Subtrai(numA, numB);
                    break;
                case 3:
                    teste.Divide(numA, numB);
                    break;
                case 4:
                    teste.Multiplica(numA, numB);
                    break;
                case 5:
                    teste.Potencia(numA, numB);
                    break;
            }
            Console.WriteLine(teste.resultado);
        }
    }
}
