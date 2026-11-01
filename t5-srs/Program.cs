
namespace Ro41Algorithms
{
    public class RecursionTasks
    {
        public static int SumOfDigits(int n)
        {
            n = Math.Abs(n);
            if (n == 0) return 0;
            return (n % 10) + SumOfDigits(n / 10);
        }

        public static double Power(double x, int n)
        {
            if (n == 0) return 1;
            if (n > 0) return x * Power(x, n - 1);
            return 1.0 / Power(x, -n);
        }
    }
}
