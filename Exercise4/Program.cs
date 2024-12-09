namespace Exercise4;

class Program
{
    public static void Main()
    {
        var phrase = Console.ReadLine();
        var count = 0;

        if (phrase == null)
        {
            Console.WriteLine(count);
            return;
        }

        foreach (var letter in phrase)
        {
            if (char.IsLetter(letter))
            {
                count++;
            }
        }

        Console.WriteLine(count);
    }
}
