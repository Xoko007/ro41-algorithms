public static class TextTools
{

    public static int CountWords(string s)
    {
        if (string.IsNullOrWhiteSpace(s)) return 0;
        
        int count = 0;
        bool inWord = false;
        
        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] != ' ' && s[i] != '\t' && s[i] != '\n' && s[i] != '\r')
            {
                if (!inWord)
                {
                    inWord = true;
                    count++;
                }
            }
            else
            {
                inWord = false;
            }
        }
        return count;
    }

    public static bool IsPalindrome(string s)
    {
        if (s == null) return true;

        int left = 0;
        int right = s.Length - 1;

        while (left < right)
        {
            while (left < right && !char.IsLetterOrDigit(s[left])) left++;
            while (left < right && !char.IsLetterOrDigit(s[right])) right--;

            if (char.ToLower(s[left]) != char.ToLower(s[right]))
                return false;

            left++;
            right--;
        }
        return true;
    }

    public static string Initials(string fullName)
    {
        if (string.IsNullOrWhiteSpace(fullName)) return string.Empty;

        
        int spaceCount = 0;
        for (int i = 0; i < fullName.Length; i++)
        {
            if (fullName[i] == ' ') spaceCount++;
        }

        string[] parts = new string[spaceCount + 1];
        int partIndex = 0;
        int startIndex = 0;

        for (int i = 0; i < fullName.Length; i++)
        {
            if (fullName[i] == ' ')
            {
                if (i > startIndex)
                {
                    parts[partIndex++] = fullName.Substring(startIndex, i - startIndex);
                }
                startIndex = i + 1;
            }
        }
        if (startIndex < fullName.Length)
        {
            parts[partIndex] = fullName.Substring(startIndex);
        }

        StringBuilder sb = new StringBuilder();
        for (int i = 0; i <= partIndex; i++)
        {
            if (!string.IsNullOrEmpty(parts[i]))
            {
                char firstChar = char.ToUpper(parts[i][0]);
                sb.Append(firstChar).Append(". ");
            }
        }

        return sb.ToString().TrimEnd();
    }

   
    public static string Repeat(string s, int n)
    {
        if (string.IsNullOrEmpty(s) || n <= 0) return string.Empty;

        StringBuilder sb = new StringBuilder(s.Length * n);
        for (int i = 0; i < n; i++)
        {
            sb.Append(s);
        }
        return sb.ToString();
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("=== Тестирование TextTools ===");

  
        Console.WriteLine($"CountWords(\"\"): {TextTools.CountWords("")} (ожидается 0)");
        Console.WriteLine($"CountWords(\"    \"): {TextTools.CountWords("    ")} (ожидается 0)");
        Console.WriteLine($"CountWords(\" a   b \"): {TextTools.CountWords(" a   b ")} (ожидается 2)");
        Console.WriteLine($"CountWords(\"Ахметов Ерлан\"): {TextTools.CountWords("Ахметов Ерлан")} (ожидается 2)");

        Console.WriteLine($"IsPalindrome(\"А роза упала на лапу Азора\"): {TextTools.IsPalindrome("А роза упала на лапу Азора")} (ожидается True)");
        
      
        Console.WriteLine($"Initials(\"Ахметов Ерлан Серикұлы\"): \"{TextTools.Initials("Ахметов Ерлан Серикұлы")}\" (ожидается \"А. Е. С.\")");

        Console.WriteLine($"Repeat(\"abc\", 3): \"{TextTools.Repeat("abc", 3)}\" (ожидается \"abcabcabc\")");
    }
}