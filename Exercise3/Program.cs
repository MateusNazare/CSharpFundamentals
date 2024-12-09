namespace Exercise3;

class Program
{
    public static void Main()
    {
        var firstNumber = 30.0;
        var secondNumber = 10.0;

        Console.WriteLine(Addition(firstNumber, secondNumber));
        Console.WriteLine(Subtraction(firstNumber, secondNumber));
        Console.WriteLine(Multiplication(firstNumber, secondNumber));
        Console.WriteLine(Division(firstNumber, secondNumber));
        Console.WriteLine(Average(firstNumber, secondNumber));
    }

    private static double Addition(double num1, double num2) => num1 + num2;

    private static double Subtraction(double num1, double num2) => num1 - num2;

    private static double Multiplication(double num1, double num2) => num1 * num2;

    private static double Division(double num1, double num2)
    {
        if (num2 == 0)
        {
            return 0;
        }

        return num1 / num2;
    }

    private static double Average(double num1, double num2) => (num1 + num2) / 2;
}

