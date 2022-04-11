using System;

namespace Algorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = Convert.ToInt32(Console.ReadLine());
            int[] _666 = new int[10001];

            int index = 1;
            int num = 666;

            while (index < 10000)
            {
                if (num.ToString().Contains("666"))
                {
                    _666[index] = num;
                    index++;
                }
                num++;
            }

            Console.WriteLine(_666[input]);
        }
    }
}
