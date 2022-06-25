using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALXCSharp.Demo
{
    public class FunctionsDemo
    {
        public static void Run()
        {
            Console.WriteLine("Functions Demo");
            WriteSentence();
            WriteConcreteSentence("Hejka");
            WriteConcreteSentence("Hejka");
            int sum = AddNumbers(2, 3);
            Console.WriteLine();
            Console.WriteLine(FormatAddress("Meander", "12", "22"));
            Console.WriteLine("\n-----\n");
        }
        /*
         * modyfikatorDostepu coZwraca Nazwa (argumenty) 
         */
        public static void WriteSentence()
        {
            Console.WriteLine("Hello");
        }

        public static void WriteConcreteSentence(string sentence)
        {
            Console.WriteLine(sentence);
        }

        // overload funkcji (jest to to samo co funkcja powyzej)
        // sygnatura funkcji: coZwraca Nazwa(argumenty)
        public static void WriteSentence(string sentence)
        {
            Console.WriteLine(sentence);
        }

        public static void WriteSentence(string sentence, int number)
        {
            Console.WriteLine($"sentence: {sentence}, number: {number}");
        }
        public static int WriteSentence(string sentence, int number, string nam)
        {
            return 0;
        }
        public static int AddNumbers(int a, int b)
        {
            return a + b;
        }

        // sygnatura funkcji np. string FormatAddress(string streetName, string buildingNumber, string flatNumber)
        public static string FormatAddress(string streetName, string buildingNumber, string flatNumber)
        {
            return $"Ulica {streetName} {buildingNumber}/{flatNumber}";

        }

        //klasy, metody, obiekty
        //obiekty
        // klasy - cechy(propoerties) i zachowania(metody = funkcje zdefiniowana w klasie) (mozna przyrownac, ze jest to tzw projekt obiektu)
    }
}
