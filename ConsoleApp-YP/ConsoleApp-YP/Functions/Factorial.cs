using System;

namespace ConsoleApp_YP.Functions
{
    internal class Factorial
    {
        private static int _digitalFactorual { get; set; }
        private static int _factorial = 1;
        public Factorial(int digital)
        {
            _digitalFactorual = digital;
            for (int i = 1; i <= digital; i++)
            {
                _factorial *= i;
            }
        }
        internal static void Display()
        {
            Console.WriteLine($"\nФакториал числа {_digitalFactorual} = {_factorial}");
        }
       

    }

}