using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1___matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] array = new int[,] {
                {1,2,3},
                {2,3,13},
                {11,48,77},
        };
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write("{0}\t", array[i, j]);
                    if (array[i, j] % 2 == 0)
                    {
                        Console.WriteLine(array[i, j]);
                    }
                }
            }
        }
    }
}



