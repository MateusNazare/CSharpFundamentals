using System.Globalization;

namespace Exercise6;

class Program
{
    public static void Main()
    {
        var dateNow = DateTime.Now;

        Console.WriteLine(dateNow.ToString("dddd, dd 'de' MMMM 'de' yyyy, HH:mm:ss"));
        Console.WriteLine(dateNow.ToString("dd/MM/yyyy"));
        Console.WriteLine(dateNow.ToString("HH:mm"));
        Console.WriteLine(dateNow.ToString("dd 'de' MMMM 'de' yyyy"));

    }
}
