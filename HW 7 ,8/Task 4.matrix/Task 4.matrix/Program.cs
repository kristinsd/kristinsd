using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4.matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int n = 30;
            int[,] array = new int[5, 6];

            for (int i = 0; i < array.GetLength(0); i++)
            {

                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = n--;
                }
            }
            for (int w = 0; w < array.GetLength(0); w++)
            {
                for (int k = 0; k < array.GetLength(1); k++)
                {
                    Console.Write("{0}\t", array[w, k]);
                }
                Console.WriteLine();
            }
        }
    }
}
