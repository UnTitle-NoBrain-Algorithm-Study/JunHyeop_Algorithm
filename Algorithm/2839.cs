using System;

namespace Algorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = -1;

            int input = Convert.ToInt32(Console.ReadLine());

            for (int numoffive = input / 5; numoffive >= 0; numoffive--)
            {
                int dif = input - numoffive * 5;
                if (dif % 3 == 0)
                {
                    count = numoffive + dif / 3;
                    break;
                }
            }

            Console.WriteLine(count);
        }
    }
}
