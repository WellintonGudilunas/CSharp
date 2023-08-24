namespace ex04;
class Program
{
    static void Main(string[] args)
    {
        System.Console.Write("Digite a Idade: ");
        int idade = int.Parse(Console.ReadLine());
        
        if(idade <= 13 && idade > 0) System.Console.WriteLine("Criança");
        else if (idade > 13 && idade <= 18) System.Console.WriteLine("Adolescente");
        else if (idade > 18 && idade <= 60) System.Console.WriteLine("Adulto");
        else if (idade > 60) System.Console.WriteLine("Idoso");
        else System.Console.WriteLine("Idade inválida");
    }
}
