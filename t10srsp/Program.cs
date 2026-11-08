public static class ArrayAlgos
{
    public static bool IsSorted(int[] a)
    {
        for (int i = 0; i < a.Length - 1; i++)
            if (a[i] > a[i + 1]) return false;
        return true;
    }

    public static int BubbleSort(int[] a)
    {
        int comps = 0;
        for (int i = 0; i < a.Length - 1; i++)
        {
            bool swapped = false;
            for (int j = 0; j < a.Length - 1 - i; j++)
            {
                comps++;
                if (a[j] > a[j + 1])
                {
                    int t = a[j]; a[j] = a[j + 1]; a[j + 1] = t;
                    swapped = true;
                }
            }
            if (!swapped) break;
        }
        return comps;
    }

    public static int CountOccurrences(int[] sortedA, int x) => 
        UpperBound(sortedA, x) - LowerBound(sortedA, x);

    private static int LowerBound(int[] a, int x)
    {
        int l = 0, r = a.Length;
        while (l < r)
        {
            int m = l + (r - l) / 2;
            if (a[m] >= x) r = m; else l = m + 1;
        }
        return l;
    }

    private static int UpperBound(int[] a, int x)
    {
        int l = 0, r = a.Length;
        while (l < r)
        {
            int m = l + (r - l) / 2;
            if (a[m] > x) r = m; else l = m + 1;
        }
        return l;
    }
}
Console.WriteLine("Hello, World!");
