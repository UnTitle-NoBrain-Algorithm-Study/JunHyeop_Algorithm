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

            Dictionary<string, Func<LinkedList<int>, int>> deque = new Dictionary<string, Func<LinkedList<int>, int>>();
            deque.Add("pop_front", PopFront);
            deque.Add("pop_back", PopBack);
            deque.Add("size", Size);
            deque.Add("empty", IsEmpty);
            deque.Add("front", Front);
            deque.Add("back", Back);

            StringBuilder sb = new StringBuilder();
            LinkedList<int> list = new LinkedList<int>();

            for (int i = 0; i < input; i++)
            {
                string data = Console.ReadLine();
                if (!data.StartsWith("push"))
                {
                    sb.AppendLine(deque[data](list).ToString());
                }
                else
                {
                    if (data.Contains("_front"))
                    {
                        list.AddFirst(Convert.ToInt32(data.Substring("push_front ".Length)));
                    }
                    else
                    {
                        list.AddLast(Convert.ToInt32(data.Substring("push_back ".Length)));
                    }
                }
            }

            Console.WriteLine(sb.ToString());
        }

        public static int PopFront(LinkedList<int> list)
        {
            int result;
            if (list.Count == 0)
            {
                result = -1;
            }
            else
            {
                result = list.First.Value;
                list.RemoveFirst();
            }

            return result;
        }

        public static int PopBack(LinkedList<int> list)
        {
            int result;
            if (list.Count == 0)
            {
                result = -1;
            }
            else
            {
                result = list.Last.Value;
                list.RemoveLast();
            }

            return result;
        }

        public static int Size(LinkedList<int> list)
        {
            return list.Count;
        }

        public static int IsEmpty(LinkedList<int> list)
        {
            return list.Count == 0 ? 1 : 0;
        }

        public static int Front(LinkedList<int> list)
        {
            return list.Count == 0 ? -1 : list.First.Value;
        }

        public static int Back(LinkedList<int> list)
        {
            return list.Count == 0 ? -1 : list.Last.Value;
        }
    }
}