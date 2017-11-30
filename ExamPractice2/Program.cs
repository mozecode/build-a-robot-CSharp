using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamPractice2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Robot Ordering App!");

            Console.WriteLine();//blank

            Console.Write("How many robots?  >> ");
            int quantity;
            int arms;
            string transmode;

            while (int.TryParse(Console.ReadLine(), out quantity)==false || quantity<0)
            { Console.Write("Try Again: "); }

            Console.ReadKey();

        }
    }
}
