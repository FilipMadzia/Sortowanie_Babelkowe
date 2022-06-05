using System;

namespace Bubble_Sorter
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = {2, 3, 5, 6, 8, 1};

            for(int i = 0; i < numbers.Length - 1; i++)
            {
                for(int j = 0; j < numbers.Length - i - 1; j++)
                {
                    if(numbers[j] > numbers[j+1])
                    {
                        int tmp = numbers[j];
                        numbers[j] = numbers[j+1];
                        numbers[j+1] = tmp;
                    }
                }
            }

            for(int k = 0; k < numbers.Length; k++)
            {
                Console.WriteLine(numbers[k]);
            }
        }
    }
}