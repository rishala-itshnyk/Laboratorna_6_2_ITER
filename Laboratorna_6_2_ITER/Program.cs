using System;

namespace Laboratorna_6_2_ITER
{
    public class Program
    {
        static void FillArray(int[] arr, int n)
        {
            Console.WriteLine($"Enter {n} elements for the array:");
            for (int i = 0; i < n; ++i)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
        }

        static void PrintArray(int[] arr, int n)
        {
            Console.Write("Array: ");
            for (int i = 0; i < n; ++i)
            {
                Console.Write($"{arr[i]} ");
            }
            Console.WriteLine();
        }

        public static void FindMinMax(int[] arr, int n, out int min, out int max)
        {
            min = int.MaxValue;
            max = int.MinValue;

            for (int i = 0; i < n; ++i)
            {
                if (arr[i] < min)
                {
                    min = arr[i];
                }
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }
        }

        static void Main()
        {
            Console.Write("Enter the size of the array: ");
            if (!int.TryParse(Console.ReadLine(), out int n) || n <= 0)
            {
                Console.Error.WriteLine("Invalid array size");
                return;
            }

            int[] arr = new int[n];

            FillArray(arr, n);
            PrintArray(arr, n);

            int minValue, maxValue;
            FindMinMax(arr, n, out minValue, out maxValue);

            Console.WriteLine($"Min: {minValue}");
            Console.WriteLine($"Max: {maxValue}");
        }
    }
}