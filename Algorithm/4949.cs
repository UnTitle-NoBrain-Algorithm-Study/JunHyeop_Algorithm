using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == ".")
                {
                    break;
                }

                sb.AppendLine(IsBalance(input));
            }


            Console.WriteLine(sb.ToString());
        }

        public static string IsBalance(string str)
        {
            Stack<char> stack = new Stack<char>();

            foreach (char item in str)
            {

                switch (item)
                {
                    case '(':
                        stack.Push(item);
                        break;
                    case '[':
                        stack.Push(item);
                        break;
                    case ')':
                        if (stack.Count == 0)
                        {
                            return "no";
                        }
                        else
                        {
                            if (stack.Peek() == '(')
                            {
                                stack.Pop();
                            }
                            else
                            {
                                return "no";
                            }
                        }
                        break;
                    case ']':
                        if (stack.Count == 0)
                        {
                            return "no";
                        }
                        else
                        {
                            if (stack.Peek() == '[')
                            {
                                stack.Pop();
                            }
                            else
                            {
                                return "no";
                            }
                        }
                        break;
                    default:
                        break;
                }
            }

            if (stack.Count == 0)
            {
                return "yes";
            }
            else
            {
                return "no";
            }
        }
    }
}