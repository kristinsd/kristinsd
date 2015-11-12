using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4_methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number:");
            int num = int.Parse(Console.ReadLine());

            EnterNumbers(num);
        }

        public static int EnterNumbers(int num)
        {
            if (num % 2 == 0)
            {
                Console.WriteLine("The number is even!");

            }
            if (num % 2 == 1)
            {
                Console.WriteLine("The number is odd!");
            }

            return num;
            {
               
            }
        }
    }
}
