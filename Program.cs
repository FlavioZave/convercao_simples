
namespace ex01;

class Program
{
    static double converteParaInt(string numeroEmString) {
        double numero = 0.0;
        for(int i = 0, j = numeroEmString.Length - 1; i < numeroEmString.Length; i++, j--) {
            if(numeroEmString[i] < 48 || numeroEmString[i] > 57 ) {
                throw new Exception("Valor inválido.");
            }
            numero += (numeroEmString[i] - 48) * Math.Pow(10, j);
        }
        return numero;
    }
    static void Main(string[] args)
    {
        Console.WriteLine("Insira um número inteiro:");
        string numeroEmString = Console.ReadLine();
        double numeroEmInt = converteParaInt(numeroEmString);
        Console.WriteLine("O numero inserido foi "+ numeroEmInt);
        Console.WriteLine("Pressione enter para continuar..");
        Console.ReadLine();
    }
}
