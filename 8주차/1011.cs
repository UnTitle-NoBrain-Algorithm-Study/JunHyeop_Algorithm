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
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < input; i++)
            {
                int[] Cur_Tar = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

                sb.AppendLine(Convert.ToString(NumberOfTiem(Cur_Tar[0], Cur_Tar[1])));
            }

            Console.WriteLine(sb);
        }

        public static int NumberOfTiem(int x, int y)
        {
            int dif = y - x;
            int sq = 1;

            while (sq * sq < dif)
            {
                sq++;
            }

            sq--;

            if (dif > sq * sq + sq)
            {
                return sq * 2 + 1;
            }
            else
            {
                return sq * 2;
            }
        }
    }
}