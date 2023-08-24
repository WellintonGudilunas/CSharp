namespace ex02;
class Program
{
    static void Main(string[] args)
    {
        System.Console.Write("Digite o valor em R$ ");
        double valor = double.Parse(Console.ReadLine());
        System.Console.WriteLine("R$" + valor + " Em Dólar: " + ConverterParaDolar(valor));
        System.Console.WriteLine("R$" + valor + " Em Euros: " + ConverterParaEuro(valor));
        System.Console.WriteLine("R$" + valor + " Em Peso Argentino: " + ConverterParaPesoArgentino(valor));
    }

    public static double ConverterParaDolar(double valor)
    {
        double valorDolar = 5.17;
        return valor * valorDolar;
    }

    public static double ConverterParaEuro(double valor)
    {
        double valorEuro = 6.14;
        return valor * valorEuro;
    }

    public static double ConverterParaPesoArgentino(double valor)
    {
        double valorPesoArgentino = 0.05;
        return valor * valorPesoArgentino;
    }
}
