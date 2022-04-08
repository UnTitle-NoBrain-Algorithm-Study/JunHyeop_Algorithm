using System;

namespace Algorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            int num = int.Parse(input);
            int result=1;

            for (int cir = 0; cir < num; cir++)
            {
                result *= 2;
            }

            Console.WriteLine(result);
        }
    }
}
