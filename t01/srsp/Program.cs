class Program
{
    static void Main()
    {
        Console.Write("Введите количество секунд: ");
        string input = Console.ReadLine();

        if (!int.TryParse(input, out int totalSeconds) || totalSeconds < 0)
        {
            Console.WriteLine("Ошибка: некорректный ввод. Введите целое неотрицательное число.");
            return;
        }

        int hours = totalSeconds / 3600;
        int remainder = totalSeconds % 3600;
        int minutes = remainder / 60;
        int seconds = remainder % 60;

        Console.WriteLine($"Результат: {hours} ч {minutes} мин {seconds} сек ({hours:D2}:{minutes:D2}:{seconds:D2})");
    }
}
