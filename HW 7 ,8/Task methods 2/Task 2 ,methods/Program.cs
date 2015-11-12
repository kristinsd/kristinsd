using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2__methods
{
    class Program
    {
        static void Main(string[] args)
        {
 
            string name;
            name = EnterName();
            Console.WriteLine("Greetings, {0} !", name);
            EnterName();
        }
        private static string EnterName()
        {
            string name;
            Console.Write("Please,enter your name: ");
            name = Console.ReadLine();
            return name;
        }
    }
}
