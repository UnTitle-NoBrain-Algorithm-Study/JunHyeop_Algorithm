using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            NODE node = new NODE();

            node.DFS(1);
            node.print();
        }
    }

    class NODE
    {
        public int input;
        public int line;
        public List<List<int>> list = new List<List<int>>();
        public bool[] visited;
        public int count = -1;

        public NODE()
        {
            input = Convert.ToInt32(Console.ReadLine());
            line = Convert.ToInt32(Console.ReadLine());
            visited = new bool[input + 1];

            for (int i = 0; i <= input; i++)
            {
                list.Add(new List<int>());
            }

            for (int i = 0; i < line; i++)
            {
                int[] data = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

                list[data[0]].Add(data[1]);
                list[data[1]].Add(data[0]);
            }
        }

        public void DFS(int start)
        {
            visited[start] = true;
            count++;
            for (int i = 0; i < list[start].Count; i++)
            {
                int next = list[start][i];
                if (!visited[next])
                {
                    DFS(next);
                }
            }
        }

        public void print()
        {
            Console.WriteLine(count);
            count = -1;
        }
    }
}