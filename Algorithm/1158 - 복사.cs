using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Array.ConvertAll(Console.ReadLine().Split(),int.Parse);
            Queue<int> queue = new Queue<int>();

            for (int i = 1; i <= input[0]; i++)
            {
                queue.Enqueue(i);
            }


            Console.WriteLine(Josephus(queue, input[1]));
        }

        public static StringBuilder Josephus(Queue<int> queue, int th)
        {
            StringBuilder result = new StringBuilder();

            result.Append('<');

            while (queue.Count!=0)
            {
                for (int i = 1; i < th; i++)
                {
                    queue.Enqueue(queue.Dequeue());
                }
                result.Append(queue.Dequeue()+", ");
            }

            result.Length -= 2;
            result.Append('>');

            return result;
        }
    }
}