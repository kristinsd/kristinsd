using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1_methods
{
    class Program
    {
        static void Main(string[] args)
        {


            int a = 11;
            int b = 33;

            Console.WriteLine(MaxNumber(a, b));
            MaxNumber(a, b);
        }
        private static int MaxNumber(int a, int b)
        {
            if (a > b)
            {
                return a;
            }

            else return b;
        }
    }
}
