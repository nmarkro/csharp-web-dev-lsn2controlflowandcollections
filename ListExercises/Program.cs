using System;

namespace ListExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Lists!");
            int[] numList = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Console.WriteLine(SumEven(numList));
            string[] words = "I would not, could not, in a box. I would not, could not with a fox. I will not eat them in a house. I will not eat them with a mouse".Split(" ");
            Console.Write("Input selected word length: ");
            int input = int.Parse(Console.ReadLine());
            PrintFilteredByLength(words, input);
        }

        static int SumEven(int[] nums)
        {
            int sum = 0;
            foreach(int i in nums)
            {
                if (i % 2 == 0)
                {
                    sum += i;
                }
            }
            return sum;
        }

        static void PrintFilteredByLength(string[] words, int length)
        {
            foreach(string s in words)
            {
                if (s.Length == length)
                {
                    Console.WriteLine(s);   
                }
            }
        }
    }
}
