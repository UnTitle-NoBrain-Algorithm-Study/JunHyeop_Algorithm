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
            Dictionary<string, string> connect = new Dictionary<string, string>();

            bool[] node=new bool[input[0]];

            for (int i = 1; i <= input[1]; i++)
            {
                string[] data = Console.ReadLine().Split();
                connect.Add(data[0], data[1]);
                connect.Add(data[1], data[0]);
            }

            DFS(node, input[2]);
            BFS(node, input[2]);
        }

        public static void DFS(bool[] node, int start)
        {
            if (node[start])
            {
                return;
            }
            node[start] = true;
            // 여기에 이프문 들어갈예정
            DFS(node, start);
        }

        public static void BFS(bool[] node, int start)
        {

        }
    }
}