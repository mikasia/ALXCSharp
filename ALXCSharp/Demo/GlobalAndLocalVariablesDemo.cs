using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALXCSharp.Demo
{
    public class GlobalAndLocalVariablesDemo
    {
        //global
        int x = 12;
        public int Value;
        public const int ConstValue = 2;
        public static void Run()
        {
            //local for RUn()
            int x = 5;
            MultiplyNumbers(2, 3);
        }

        private static void MultiplyNumbers(int v1, int v2)
        {
            //local for MultiplyNumbers
            var product = v1 * v2 + ConstValue;
            Console.WriteLine($"Product: {product}");
        }
    }
}
