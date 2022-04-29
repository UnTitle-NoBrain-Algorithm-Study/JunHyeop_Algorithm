using System;
using System.Collections.Generic;

namespace Algorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = Convert.ToInt32(Console.ReadLine());
            int[] arr=new int[input];
            long sum = 0;

            for (int i = 0; i < input; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            Array.Sort(arr);

            for (int j = 0; j < input; j++)
            {
                sum += Math.Abs(j + 1 - arr[j]);
            }

            Console.WriteLine(sum);
        }
    }
}
