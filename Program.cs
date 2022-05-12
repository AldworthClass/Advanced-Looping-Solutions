using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_Looping_Solutions
{
    class Program
    {
        static void Main(string[] args)
        {
            LoopQ2();
            Console.ReadLine();
        }

        // Question 1
        public static void LoopQ1()
        {
            for (int i = 0; i < 10; i++)
                Console.Write("*");
        }

        public static void LoopQ2()
        {
            for (int i = 0; i < 10; i++)
                Console.Write("*");
            Console.WriteLine();

            for (int i = 0; i < 5; i++)
                Console.Write("*");
            Console.WriteLine();

            for (int i = 0; i < 20; i++)
                Console.Write("*");
            Console.WriteLine();

        }
    }
}
