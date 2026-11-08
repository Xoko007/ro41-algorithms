class Program
{
    static void Main()
    {
        Console.WriteLine("=== СРС 8: Демонстрация работы со строками ==\n");

        string s = "  Ахметов Ерлан;85 ";
        string trimmed = s.Trim();
        string[] parts = trimmed.Split(';');
        
        Console.WriteLine($"1. Trim и Split:");
        Console.WriteLine($"   Исходная: \"{s}\"");
        Console.WriteLine($"   После Trim: \"{trimmed}\"");
        for (int i = 0; i < parts.Length; i++)
        {
            Console.WriteLine($"   Часть [{i}]: \"{parts[i]}\" (длина: {parts[i].Length})");
        }

        Console.WriteLine($"\n2. int.TryParse валидация:");
        string[] lineParts = { "Иванов Пётр", "70", "85", "x" };
        for (int i = 0; i < lineParts.Length; i++)
        {
            bool success = int.TryParse(lineParts[i], out int result);
            Console.WriteLine($"   Индекс {i} (\"{lineParts[i]}\"): TryParse = {success}, out = {result}");
        }

        Console.WriteLine($"\n3. Сравнение string (создание новых объектов) и StringBuilder:");
        string str = "";
        for (int i = 0; i < 4; i++)
        {
            str += i;
            Console.WriteLine($"   string шаг {i}: \"{str}\"");
        }

        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < 4; i++)
        {
            sb.Append(i);
        }
        Console.WriteLine($"   StringBuilder результат: \"{sb.ToString()}\"");

    
        Console.WriteLine($"\n4. Неизменяемость string (ToUpper без присваивания):");
        string original = "ерлан";
        original.ToUpper();
        Console.WriteLine($"   После original.ToUpper() без присваивания: \"{original}\" (осталась прежней)");
        original = original.ToUpper();
        Console.WriteLine($"   После original = original.ToUpper(): \"{original}\"");
    }
}