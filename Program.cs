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
            LoopQ8();
            Console.ReadLine();
        }

        // Question 1
        public static void LoopQ1()
        {
            for (int i = 0; i < 10; i++)
                Console.Write("* ");
        }

        public static void LoopQ2()
        {
            for (int i = 0; i < 10; i++)
                Console.Write("* ");
            Console.WriteLine();

            for (int i = 0; i < 5; i++)
                Console.Write("* ");
            Console.WriteLine();

            for (int i = 0; i < 20; i++)
                Console.Write("* ");
            Console.WriteLine();
        }

        public static void LoopQ3()
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                    Console.Write("* ");
                Console.WriteLine("");
            }
        }

        public static void LoopQ4()
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 5; j++)
                    Console.Write("* ");
                Console.WriteLine("");
            }
        }

        public static void LoopQ5()
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 20; j++)
                    Console.Write("* ");
                Console.WriteLine("");
            }
        }

        public static void LoopQ6()
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                    Console.Write($"{j} ");
                Console.WriteLine("");
            }
        }

        public static void LoopQ7()
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                    Console.Write($"{i} ");
                Console.WriteLine("");
            }
        }

        public static void LoopQ8()
        {
            for (int i = 0; i < 10; i++)
            {
                // Spaces
                for (int k = 0; k < i; k++)
                    Console.Write("  ");
                // Numbers
                for (int j = 0; j < 10 - i; j++)
                    Console.Write($"{j} ");
                Console.WriteLine("");
            }
        }


    }
}
