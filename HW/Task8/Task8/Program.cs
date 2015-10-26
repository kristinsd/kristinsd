using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your scores");
            int score = int.Parse(Console.ReadLine());

            if (score >= 1 && score <= 3) 
            {
                Console.WriteLine(score * 5);

            }
            if (score >=4 && score <=6)
            {
                Console.WriteLine(score * 10);

            }
            if (score >=7 && score <=9)
            {
                Console.WriteLine(score * 50);
            }


        }
    }
}
