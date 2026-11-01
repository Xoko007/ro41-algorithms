
namespace Ro41Algorithms
{
    public static class ArrayOps
    {

        public static int Sum(int[] a)
        {
            if (a == null) return 0;
            int sum = 0;
            for (int i = 0; i < a.Length; i++)
            {
                sum += a[i];
            }
            return sum;
        }

        public static int IndexOfMin(int[] a)
        {
            if (a == null || a.Length == 0) throw new ArgumentException("Массив пуст");
            int minIndex = 0;
            int minVal = a[0];
            for (int i = 1; i < a.Length; i++)
            {
                if (a[i] < minVal)
                {
                    minVal = a[i];
                    minIndex = i;
                }
            }
            return minIndex;
        }

        
        public static int CountGreater(int[] a, int x)
        {
            if (a == null) return 0;
            int count = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] > x)
                {
                    count++;
                }
            }
            return count;
        }


        public static void Reverse(int[] a)
        {
            if (a == null || a.Length <= 1) return;
            for (int i = 0; i < a.Length / 2; i++)
            {
                int temp = a[i];
                a[i] = a[a.Length - 1 - i];
                a[a.Length - 1 - i] = temp;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int[][] testArrays = new int[][]
            {
                new int[] { 4, 1, 7, 3, 9 },
                new int[] { 5 },
                new int[] { -2, -7, -4 },
                new int[] { 2, 2, 2 }
            };

            foreach (var arr in testArrays)
            {
                int[] original = (int[])arr.Clone();

                Console.WriteLine("Исходный массив: " + string.Join(", ", original));
                Console.WriteLine("Сумма: " + ArrayOps.Sum(original));
                Console.WriteLine("Индекс минимума: " + ArrayOps.IndexOfMin(original));
                Console.WriteLine("CountGreater (x = 2): " + ArrayOps.CountGreater(original, 2));

                ArrayOps.Reverse(arr);
                Console.WriteLine("Массив после Reverse: " + string.Join(", ", arr));
                Console.WriteLine(new string('-', 35));
            }
        }
    }
}