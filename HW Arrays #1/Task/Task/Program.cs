using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    class Program
    {
        static void Main(string[] args)
        {
            int arrayLength = int.Parse(Console.ReadLine());
            int[] array = new int[arrayLength];

            array[0] = 1;
            array[1] = 1;

            for (int i = 2; i < array.Length; i++)
            {

                array[i] = (array[i - 1] + array[i - 2]);

            }
            for (int a = 0; a < array.Length; a++)

            {

                Console.Write(" " + array[a]);

            }
        }
    }
}
