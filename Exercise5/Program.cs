namespace Exercise5;

class Program
{
    public static void Main()
    {
        Console.Write("Digite a placa: ");
        var plate = Console.ReadLine();

        if (plate == null || plate.Length != 7)
        {
            Console.WriteLine("Falso");
            return;
        }

        for (int i = 0; i < plate.Length; i++)
        {
            if ((i < 3 && char.IsLetter(plate[i]) == false) 
                || (i > 2 && char.IsDigit(plate[i]) == false))
            {
                Console.WriteLine("Falso");
                return;
            }
        }

        Console.WriteLine("Verdadeiro");
    }
}
