using System;
using System.Linq;

namespace Algorithm
{
    public class Solution
    {
        public int solution(int n)
        {
            if (n == 0)
            {
                return 0;
            }

            int answer = 0;

            for (int num = 1; num <= Math.Sqrt(n); num++)
            {
                if (n % num == 0)
                {
                    if (n/num == num)
                    {
                        answer += num;
                    }
                    else
                    {
                        answer += num + (n/num);
                    }
                }
            }

            return answer;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            Solution solution = new Solution();

            int result = solution.solution(input);

            Console.WriteLine(result);
        }
    }
}
