using System;

namespace Sorts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 8, 3, 9, 1, 2, 4 };

            CoctailSort<int> coctailSort = new(array);

            coctailSort.Sort();

            Console.Write("Result: ");
            foreach (int item in array)
                Console.Write($"{item} ");

            Console.WriteLine();
        }
    }
}
