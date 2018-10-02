using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Replicon_Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number.");
            int i = Convert.ToInt32(Console.ReadLine());
            int displayIterNumber = GetFactorial(i);
            Console.WriteLine("The factorial for the provided number using iteration is :{0}", displayIterNumber);
            int displayRecNumber = GetFactorialRec(i);
            Console.WriteLine("The factorial for the provided number using recursion is :{0}", displayRecNumber);
            Console.ReadLine();
        }

        public static int GetFactorial(int n)
        {
            int fact = 1;
            for (int j = 1; j <= n; j++)
            {
                fact = fact * j;
            }
            return fact;
        }

        public static int GetFactorialRec(int n)
        {
            if (n == 0) return 1;
            else
                return  n * GetFactorialRec(n - 1);
        }
    }
}
