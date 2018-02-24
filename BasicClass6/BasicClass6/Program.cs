using System;

class Program
{
    public static void Main()
    {
        int[] arr = new int[] { 16, 48, 79, -6, 36, 0, 9, 6 };
        Array.Sort(arr);
        Array.ForEach(arr, Console.WriteLine);
    }
}