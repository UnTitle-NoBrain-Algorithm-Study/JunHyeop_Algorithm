using System;
using System.Linq;

namespace Algorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            const int SIZE = 1001;

            bool[] eratosthenes = Enumerable.Repeat<bool>(true, SIZE).ToArray<bool>();

            eratosthenes[0] = false;
            eratosthenes[1] = false;

            for (int raise = 2; raise < Math.Sqrt(SIZE); raise++)
            {
                if (eratosthenes[raise] == false)
                {
                    continue;
                }
                else
                {
                    for (int index = raise * 2; index < SIZE; index += raise)
                    {
                        eratosthenes[index] = false;
                    }
                }
            }

            int input = Convert.ToInt32(Console.ReadLine());
            int count = 0;
            string[] inputnum = Console.ReadLine().Split();

            int[] arr = Array.ConvertAll(inputnum,int.Parse);

            for (int index = 0; index < input; index++)
            {
                if (eratosthenes[arr[index]])
                {
                    count++;
                }
            }

            Console.WriteLine(count);
        }
    }
}
