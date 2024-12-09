namespace Exercise2;

class Program
{
    public static void Main()
    {
        Console.Write("Digite seu nome: ");
        var firstName = Console.ReadLine();

        Console.Write("Digite seu sobrenome: ");
        var lastName = Console.ReadLine();

        Console.WriteLine($"Nome completo: {firstName} {lastName}");
    }
}
