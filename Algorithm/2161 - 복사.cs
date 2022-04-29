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
            List<int> output = new List<int>();
            int index = -1;

            for (int i = 0; i < input; i++)
            {
                string[] str = Console.ReadLine().Split();

                switch (str[0])
                {
                    case "push":
                        arr.Add(Convert.ToInt32(str[1]));
                        index++;
                        break;
                    case "pop":
                        if (index == -1)
                        {
                            output.Add(-1);
                        }
                        else
                        {
                            output.Add(arr[index]);
                            arr.RemoveAt(index);
                            index--;
                        }
                        break;
                    case "size":
                        output.Add(index + 1);
                        break;
                    case "empty":
                        if (index == -1)
                        {
                            output.Add(1);
                        }
                        else
                        {
                            output.Add(0);
                        }
                        break;
                    case "top":
                        if (index == -1)
                        {
                            output.Add(index);
                        }
                        else
                        {
                            output.Add(arr[index]);
                        }
                        break;
                }
            }

            foreach (int item in output)
            {
                Console.WriteLine(item);
            }
        }
    }
}
