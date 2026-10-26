
class Program
{
    static void Main()
    {
        Console.Write("Введите целое неотрицательное число n: ");
        string input = Console.ReadLine();

        if (!int.TryParse(input, out int n) || n < 0)
        {
            Console.WriteLine("Ошибка: некорректный ввод. Требуется неотрицательное целое число.");
            return;
        }

        int sum = 0;
        int count = 0;
        int temp = n;

        do
        {
            sum += temp % 10;
            count++;
            temp /= 10;
        }
        while (temp > 0);

        Console.WriteLine($"Количество цифр: {count}");
        Console.WriteLine($"Сумма цифр: {sum}");
    }
}