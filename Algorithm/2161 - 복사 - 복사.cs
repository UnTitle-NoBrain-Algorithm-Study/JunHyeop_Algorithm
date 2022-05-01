using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputCount = int.Parse(Console.ReadLine());
            Dictionary<string, Func<Stack<int>, int>> functionDic = new Dictionary<string, Func<Stack<int>, int>>();
            functionDic.Add("empty", IsEmpty);
            functionDic.Add("size", Size);
            functionDic.Add("top", Top);
            functionDic.Add("pop", Pop);

            StringBuilder resultBuilder = new StringBuilder();
            Stack<int> stack = new Stack<int>();
            for (int index = 0; index < inputCount; ++index)
            {
                string data = Console.ReadLine();
                if (!data.StartsWith("push"))
                    resultBuilder.AppendLine(functionDic[data](stack).ToString());
                else
                    stack.Push(int.Parse(data.Substring("push ".Length)));
            }

            Console.WriteLine(resultBuilder.ToString());
        }

        public static int IsEmpty(Stack<int> stack)
        {
            int result = stack.Count != 0 ? 0 : 1;
            return result;
        }

        public static int Top(Stack<int> stack)
        {
            if (stack.Count != 0)
                return stack.Peek();
            else
                return -1;
        }

        public static int Size(Stack<int> stack)
        {
            return stack.Count;
        }

        public static void Push(Stack<int> stack, int number)
        {
            stack.Push(number);
        }

        public static int Pop(Stack<int> stack)
        {
            if (stack.Count != 0)
                return stack.Pop();
            else return -1;
        }
    }
}