using System;
using System.Collections.Generic;
using System.Linq;

namespace Sortowanie_bąbelkowe
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberCount = 10;
            bool sorted = false;

            int[] numbers = new int[numberCount];

            Console.WriteLine("Podaj 10 liczb, po każdej kliknij 'Enter'");
            for(int i = 0; i < numberCount; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }

            while(!sorted)
            {
                foreach(int number in numbers)
                {
                    
                }
            }
        }
    }
}
