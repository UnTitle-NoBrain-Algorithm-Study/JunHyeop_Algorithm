using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm
{
    class NODE
    {
        public int N; // 정점의 개수
        public int M; // 간선의 개수
        public int V; // 시작 정점
        StringBuilder str = new StringBuilder();



        List<List<int>> adj;
        bool[] visited;

        public NODE(int n, int m, int v)
        {
            N = n;
            M = m;
            V = v;

            adj= new List<List<int>>(N);
            visited = new bool[N + 1];

            for (int i = 0; i <= N; i++)
            {
                adj.Add(new List<int>());
            }

            for (int i = 0; i < M; i++)
            {
                int[] connect = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                adj[connect[0]].Add(connect[1]);
                adj[connect[0]].Sort();
                adj[connect[1]].Add(connect[0]);
                adj[connect[1]].Sort();
            }
        }

        public void DFS(int V)
        {
            visited[V] = true;
            str.Append(V+" ");
            for (int i = 0; i < adj[V].Count; i++)
            {
                int next = adj[V][i];
                if (!visited[next])
                {
                    DFS(next);
                }
            }

            str.Remove(str.Length - 1, 1);

            Console.WriteLine(str);
            str.Clear();
        }


    }



    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

            NODE node = new NODE(input[0], input[1], input[2]);

            node.DFS(input[2]);
        }
    }
}