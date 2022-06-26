using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALXCSharp.Demo
{
    public class LoopsDemo
    {
        public static void Run()
        {
            int[] digitArray = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };


            var sum1 = 0;
            foreach (var digit in digitArray)
            {
                sum1 = sum1 + digit;
                Console.WriteLine(sum1);
            }

            Console.WriteLine();


            var sum2 = 0;

            for(int i = 0; i < digitArray.Length; i++)
            {
                sum2 = sum2 + digitArray[i];
                Console.WriteLine($"Sum od digits {sum2}");
            }
            Console.WriteLine();
            sum1 = 0;
            for (int i = 0; i < 4; i++)
            {
                sum1 = sum1 + digitArray[i];
                Console.WriteLine($"Sum od digits {sum1}");
            }

            Console.WriteLine();
            sum1 = 0;
            for (int i = digitArray.Length-1; i >= 0; i--)
            {
                sum1 = sum1 + digitArray[i];
                Console.WriteLine($"Sum of digits {sum1}");
            }


            Console.WriteLine();
            Console.WriteLine("While");
            sum1 = 0;
            var iterator = 0;
            while (sum1 + digitArray[iterator] < 20)
            {
                sum1 = sum1 + digitArray[iterator];
                Console.WriteLine($"Sum of digits {sum1}");
                iterator++;
            }

            Console.WriteLine();

            Console.WriteLine("Do While");
            // do while m konkrolowane wyjście, a while ma kontrolowane wejscie, wiec do while musi sie wykonac co najmniej raz
            sum1 = 0;
            iterator = 0;
            do 
            {
                sum1 = sum1 + digitArray[iterator];
                Console.WriteLine($"Sum of digits {sum1}");
                iterator++;
            }
            while (sum1 + digitArray[iterator] < 20);

            Console.WriteLine();

        }



    }
}
