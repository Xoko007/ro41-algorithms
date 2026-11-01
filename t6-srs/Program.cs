
namespace Ro41Algorithms
{
    public class SRS6ArrayTasks
    {
        public static void Main(string[] args)
        {
     
            int[] a = { 4, 1, 7, 3, 9 };
            Console.WriteLine("Исходный массив: " + string.Join(", ", a));


            ShiftLeft(a);
            Console.WriteLine("После сдвига влево: " + string.Join(", ", a));

        
            a = new int[] { 4, 1, 7, 3, 9 };


            ReverseArray(a);
            Console.WriteLine("После разворота: " + string.Join(", ", a));

            int[] testArray = { 5, 8, 12, 3, 9 };
            int minVal = FindMinimumCorrect(testArray);
            Console.WriteLine($"Минимальный элемент: {minVal}");
        }


        public static void ShiftLeft(int[] arr)
        {
            if (arr == null || arr.Length <= 1) return;
            int buffer = arr[0]; 
            for (int i = 0; i < arr.Length - 1; i++)
            {
                arr[i] = arr[i + 1];
            }
            arr[arr.Length - 1] = buffer;
        }

    
        public static void ReverseArray(int[] arr)
        {
            if (arr == null) return;
            int n = arr.Length;
            for (int i = 0; i < n / 2; i++)
            {
                int temp = arr[i];
                arr[i] = arr[n - 1 - i];
                arr[n - 1 - i] = temp;
            }
        }
        public static int FindMinimumCorrect(int[] arr)
        {
            if (arr == null || arr.Length == 0) throw new ArgumentException("Массив пуст");
            
            int min = arr[0]; 
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] < min)
                {
                    min = arr[i];
                }
            }
            return min;
        }
    }
}