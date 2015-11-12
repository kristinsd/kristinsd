using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3__methods
{
    class Program
    {
        static void Main(string[] args)
        {

            int param1 = int.Parse(Console.ReadLine());
            int param2 = int.Parse(Console.ReadLine());
            int param3 = int.Parse(Console.ReadLine());
            {
                Console.WriteLine(SumOfTheParam(param1, param2, param3));
            }
            //for (int i = 0; i < 11; i++)
            //{
            //    SumOfTheParam;
            //}


            SumOfTheParam(param1, param2, param3);
        }

        static int SumOfTheParam(int param1, int param2, int param3)
        {
            int sum = param1 * param2 * param3;
            return sum;


        }
    }
}
