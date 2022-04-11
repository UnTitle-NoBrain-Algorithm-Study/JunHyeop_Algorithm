using System;

namespace Algorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = Convert.ToInt32(Console.ReadLine());
            const int MAXINDEX = 1000;
            int[] square = new int[MAXINDEX];

            square[0] = 1;
            square[1] = 2;

            for (int index = 2; index < MAXINDEX; index++)
            {
                square[index] = (square[index - 1] + square[index - 2]) % 10007;
            }

            Console.WriteLine(square[input - 1]);
        }
    }
}
