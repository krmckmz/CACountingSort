using System;
using System.Linq;

namespace CACountingSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] givenArray = { 1, 7, 2, 5, 0, 3 };
            int[] sortedArray = Sort(givenArray);
            PrintArray(sortedArray);
        }

        static int[] Sort(int[] Array)
        {
            int length = Array.Length;
            int maxValue = Array.Max();

            int[] frequencyArray = new int[maxValue + 1];
            for (int i = 0; i < length; i++)
                frequencyArray[i] = default(int);

            for (int i = 0; i < length; i++)
                frequencyArray[Array[i]]++;

            for (int i = 0; i <= maxValue; i++)
            {
                int j = 0;
                while (frequencyArray[i] > 0)
                {
                    Array[j] = i;
                    frequencyArray[i]--;
                    j++;
                }
            }

            return Array;
        }

        static void PrintArray(int[] Array)
        {
            int n = Array.Length;
            for (int i = 0; i < n; i++)
                Console.Write(Array[i] + " ");
            Console.Write("\n");
        }
    }
}
