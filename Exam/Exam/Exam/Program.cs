using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] array1 = new int[n * n];
            int[,] arr2 = new int[3, 3];

            int sum = 0;
            int counter = 0;
            Random rand = new Random();
            for (int i = 0; i < array1.Length; i++)
            {
                array1[i] = rand.Next(0, 9);
                sum += array1[i];
                Console.WriteLine("{0}\t", array1[i]);
            }
            Console.WriteLine();
            for (int i = 0; i < arr2.GetLength(0); i++)
            {
                for (int j = 0; j < arr2.GetLength(1); j++)
                {
                    arr2[j, i] = array1[counter++];
                }

            }
            for (int i = 0; i < arr2.GetLength(0); i++)
            {
                for (int j = 0; j < arr2.GetLength(1); j++)
                {
                    Console.Write("{0}\t", arr2[i, j]);

                }
                Console.WriteLine();

            }

            Console.WriteLine("SUM: {0}", sum);
        }
    }
}



