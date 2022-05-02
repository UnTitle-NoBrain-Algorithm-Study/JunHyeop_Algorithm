using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = Convert.ToInt32(Console.ReadLine());


            StringBuilder result = new StringBuilder();

            for (int i = 0; i < input; i++)
            {
                string data = Console.ReadLine();
                result.AppendLine(Inspect(data));
            }

            Console.WriteLine(result);
        }

        public static string Inspect(string data)
        {
            Stack<int> stack = new Stack<int>();

            foreach (char item in data)
            {
                switch (item)
                {
                    case '(':
                        stack.Push(item);
                        break;
                    case ')':
                        if (stack.Count > 0)
                        {
                            if (stack.Peek() == '(')
                            {
                                stack.Pop();
                            }
                            else
                            {
                                return "NO";

                            }
                        }
                        else
                        {
                            return "NO";
                        }
                        break;
                }
            }

            if (stack.Count == 0)
            {
                return "YES";
            }
            else
            {
                return "NO";
            }

        }
    }
}