using System;

namespace Algorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = Convert.ToInt32(Console.ReadLine());
            const int MAXINDEX = 91;
            long[] fibonacci = new long[MAXINDEX];

            fibonacci[0] = 0;
            fibonacci[1] = 1;

            for (int i = 2; i < MAXINDEX; i++)
            {
                fibonacci[i] = fibonacci[i - 1] + fibonacci[i - 2];
            }


            int count = 0;
            foreach (var item in fibonacci)
            {
                Console.WriteLine($"{count}번째 : {item}");
                count++;
            }

            Console.WriteLine(fibonacci[input]);
        }
    }
}
