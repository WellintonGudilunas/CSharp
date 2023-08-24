namespace ex01;


class Program
{
    static void Main(string[] args)
    {
        Console.Write("Digite a altura do retângulo: ");
        double altura = double.Parse(Console.ReadLine());

        Console.Write("Digite a largura do retângulo: ");
        double largura = double.Parse(Console.ReadLine());

        Console.WriteLine("A área do retangulo é: " + CalculaAreaRetangulo(altura, largura));
    }

    public static double CalculaAreaRetangulo(double altura, double largura)
    {
        return altura * largura;
    }
}
