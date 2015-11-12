using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 2, 22, 12, 1, 5 };
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                {
                    sum += array[i];
                }

                Console.WriteLine(sum);
            }
        }
    }
}
