
class Program
{
    static void Main()
    {
        Console.Write("Введите a: ");
        string inputA = Console.ReadLine();
        Console.Write("Введите b: ");
        string inputB = Console.ReadLine();

        if (!int.TryParse(inputA, out int a) || !int.TryParse(inputB, out int b) || 
            a < 0 || b < 0 || (a == 0 && b == 0))
        {
            Console.WriteLine("Ошибка: некорректный ввод. Требуются неотрицательные числа, не равные нулю одновременно.");
            return;
        }

        while (b != 0)
        {
            int r = a % b;
            a = b;
            b = r;
        }

        Console.WriteLine($"Наибольший общий делитель (НОД): {a}");
    }
}
