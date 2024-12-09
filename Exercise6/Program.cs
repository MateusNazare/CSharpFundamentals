namespace Exercise6;

class Program
{
    public static void Main()
    {
        while (true)
        {
            Console.WriteLine();
            Console.WriteLine("Escolha o formato para exibição da data e hora:");
            Console.WriteLine("1. Formato completo (dia da semana, dia do mês, mês, ano, hora, minutos, segundos)");
            Console.WriteLine("2. Apenas a data no formato \"01/03/2024\"");
            Console.WriteLine("3. Apenas a hora no formato de 24 horas");
            Console.WriteLine("4. A data com o mês por extenso");
            Console.WriteLine("5. Sair");
            Console.Write("Digite sua opção: ");

            string? option = Console.ReadLine();
            var dateNow = DateTime.Now;

            switch (option)
            {
                case "1":
                    Console.WriteLine(dateNow.ToString("dddd, dd, MMMM, yyyy, HH, mm, ss"));
                    break;
                case "2":
                    Console.WriteLine(dateNow.ToString("dd/MM/yyyy"));
                    break;
                case "3":
                    Console.WriteLine(dateNow.ToString("HH:mm"));
                    break;
                case "4":
                    Console.WriteLine(dateNow.ToString("dd 'de' MMMM 'de' yyyy"));
                    break;
                case "5":
                    Console.WriteLine("Você saiu.");
                    return;
                default:
                    Console.WriteLine("Opção inválida.");
                    break;
            }
        }
    }
}
