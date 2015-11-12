using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2_matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] array = new int[3, 4];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = int.Parse(Console.ReadLine());
                }
            }
            for (int k = 0; k < array.GetLength(0); k++)
            {
                for (int w = 0; w < array.GetLength(1); w++)
                {
                    Console.Write("{0}\t", array[k,w]);
                }
                
            }
        }
    }
}
