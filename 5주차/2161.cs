using System;
using System.Collections.Generic;

namespace Algorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = Convert.ToInt32(Console.ReadLine());
            List<int> arr = new List<int>();
            int[] output = new int[input];
            int index = 0;

            for (int i = 1; i <= input; i++)
            {
                arr.Add(i);
            }

            for (int j = 0; j < input * 2 - 1; j += 2)
            {
                output[index] = arr[j];
                index++;

                try
                {
                    arr.Add(arr[j + 1]);
                }
                catch (Exception)
                {
                    break;
                    throw;
                }
            }

            foreach (int item in output)
            {
                Console.Write(item + " ");
            }
        }
    }
}
