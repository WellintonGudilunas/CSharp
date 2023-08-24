namespace ex03;
class Program
{
    static void Main(string[] args)
    {
        System.Console.Write("Digite o primeiro número: ");
        int n1 = int.Parse(Console.ReadLine());
        System.Console.Write("Digite o segundo número: ");
        int n2 = int.Parse(Console.ReadLine());

        System.Console.WriteLine("O maior valor é: " + (n1 > n2 ? n1 : n2));
    }
}
