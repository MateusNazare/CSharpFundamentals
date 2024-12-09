namespace Exercise4;

class Program
{
    public static void Main()
    {
        Console.Write("Digite uma frase: ");
        var phrase = Console.ReadLine();
        var count = 0;

        Console.Write("A quantidade de caracteres é: ");

        if (phrase == null)
        {
            Console.Write(0);
            return;
        }

        foreach (var letter in phrase)
        {
            if (char.IsLetter(letter))
            {
                count++;
            }
        }

        Console.Write(count);
    }
}
