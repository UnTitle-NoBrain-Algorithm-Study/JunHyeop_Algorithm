using System;

namespace Algorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = Convert.ToInt32(Console.ReadLine());
            int[] A = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int[] B = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

            int S = 0;

            Array.Sort(A);
            Array.Sort(B);
            Array.Reverse(B);

            for (int index = 0; index < input; index++)
            {
                S += A[index] * B[index];
            }

            Console.WriteLine(S);
        }
    }
}
