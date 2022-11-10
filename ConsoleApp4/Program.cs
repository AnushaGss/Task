using System;
class Program
{
    public static bool areEqual(int[] arr1, int[] arr2)
    {
        int n = arr1.Length;
        int m = arr2.Length;

        Array.Sort(arr1);
        Array.Sort(arr2);

        for (int i = 0; i < n; i++)
            if (arr1[i] != arr2[i])
                return false;
        return true;
    }
    static void Main()
    {
        int[] arr1 = { 1, 4, 7, 9, 1 };
        int[] arr2 = { 4, 1, 1, 9, 7 };

        if (areEqual(arr1, arr2))
            Console.WriteLine("Yes");
        else
            Console.WriteLine("No");
    }
}