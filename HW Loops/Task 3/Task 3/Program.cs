using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int nums = 0;
            int.TryParse(Console.ReadLine(), out nums);
            int minNum = int.MaxValue;
            int maxNum = int.MinValue;
            int n = 0;
            for (int i = 0; i < nums; i++)
            {
                Console.WriteLine("Nummber: ");
                int.TryParse(Console.ReadLine(), out n);

                if (n > maxNum)
                {
                    maxNum = n;
                }
                if (n < minNum)
                {
                    minNum= n;
                }
            }
            Console.WriteLine("Min: {0}.", minNum);
            Console.WriteLine("Max: {0}.", maxNum);
        }

        }
}
