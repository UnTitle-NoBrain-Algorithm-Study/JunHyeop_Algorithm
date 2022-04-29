using System;
using System.Collections.Generic;

namespace Algorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            int input= Convert.ToInt32(Console.ReadLine());
            string[] word = new string[input];
            List<string> words = new List<string>();

            for (int index = 0; index < input; index++)
            {
                word[index] = Console.ReadLine();
            }

            Array.Sort(word);

            for (int index = 0; index < input - 1; index++)
            {
                if (word[index] == word[index + 1])
                {
                    continue;
                }
                
                words.Add(word[index]);
            }

            words.Add(word[input - 1]);

            for (int i = 0; i < words.Count - 1; i++)
            {
                for (int j = 0; j < words.Count - 1; j++)
                {
                    if (words[j].Length > words[j + 1].Length)
                    {
                        string temp = words[j];
                        words[j] = words[j + 1];
                        words[j + 1] = temp;
                    }
                }
            }

            foreach (string item in words)
            {
                Console.WriteLine(item);
            }
        }
    }
}
