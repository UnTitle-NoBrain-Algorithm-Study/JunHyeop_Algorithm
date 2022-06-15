using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            StepNum stepnum = new StepNum();

            Console.WriteLine(stepnum.clac());
        }
    }

    class StepNum
    {
        int input;
        List<List<int>> list;

        public StepNum()
        {
            input = Convert.ToInt32(Console.ReadLine());
            list = new List<List<int>>(input);

            for (int i = 0; i < input; i++)
            {
                list.Add(new List<int>(10));
            }

            List<int> initial = new List<int>();
            initial.Add(0);

            for (int i = 0; i < 9; i++)
            {
                initial.Add(1);
            }
            
            list[0] = initial;
        }

        public int clac()
        {
            int result = 0;

            for (int i = 1; i < input; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (j == 0)
                    {
                        list[i].Add(list[i - 1][1]);
                    }
                    else if (j == 9)
                    {
                        list[i].Add(list[i - 1][8]);
                    }
                    else
                    {
                        list[i].Add(list[i - 1][j - 1] + list[i - 1][j + 1]);
                    }
                    list[i][j] %= 1000000000;
                }
            }

            for (int k = 0; k < 10; k++)
            {
                result += list[input - 1][k];
                result %= 1000000000;
            }

            return result;
        }
    }
}