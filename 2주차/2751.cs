using System;
using System.Text;

namespace Algorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int[] numbersarr = new int[number];

            for (int index = 0; index < number; index++)
            {
                numbersarr[index] = int.Parse(Console.ReadLine());
            }

            Array.Sort(numbersarr);

            StringBuilder sb = new StringBuilder(string.Join("\n", numbersarr));

            Console.WriteLine(sb);
        }
    }
}
