
namespace Ro41Algorithms
{
    public static class Rec
    {
  
        public static int DigitSum(int n)
        {
            n = Math.Abs(n);
            
        
            if (n < 10)
            {
                return n;
            }
            
           
            return (n % 10) + DigitSum(n / 10);
        }

       
        public static long Pow(int x, int n)
        {
            
            if (n == 0)
            {
                return 1;
            }
            
           
            return x * Pow(x, n - 1);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
       
            int[] digitTests = { 0, 7, 12345, 1000 };
            foreach (int val in digitTests)
            {
                Console.WriteLine($"DigitSum({val}) = {Rec.DigitSum(val)}");
            }

            (int x, int n)[] powTests = { (2, 0), (2, 10), (5, 3), (7, 1) };
            foreach (var test in powTests)
            {
                Console.WriteLine($"Pow({test.x}, {test.n}) = {Rec.Pow(test.x, test.n)}");
            }
        }
    }
}
