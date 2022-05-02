using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = Convert.ToInt32(Console.ReadLine());
            List<int> arr = new List<int>();

            for (int i = 0; i < input; i++)
            {
                arr.Add(Convert.ToInt32(Console.ReadLine()));
            }

            arr.Sort();

            Console.WriteLine(ArithmeticMean(arr));
            Console.WriteLine(Medianvalue(arr));
            Console.WriteLine(Mode(arr));
            Console.WriteLine(Range(arr));
        }

        public static int ArithmeticMean(List<int> arr)
        {
            int result = (int)Math.Round((double)arr.Sum() / arr.Count, 0);

            return result;
        }

        public static int Medianvalue(List<int> arr)
        {
            return arr[arr.Count / 2];
        }

        public static int Mode(List<int> arr)
        {
            int max = 0;
            bool tf = false;
            int result = 0;


            foreach (var item in arr.GroupBy(x => x))
            {
                if (max < item.Count())
                {
                    max = item.Count();
                    tf = true;
                    result = item.Key;
                }
                else if (max == item.Count())
                {
                    if (tf)
                    {
                        result = item.Key;
                        tf = false;
                    }
                }
            }

            return result;
        }

        public static int Range(List<int> arr)
        {
            return arr[arr.Count() - 1] - arr[0];
        }
    }
}