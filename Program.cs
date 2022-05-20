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
            Menu();          
        }

        // Question 1
        public static void LoopQ1()
        {
            for (int i = 0; i < 10; i++)
                Console.Write("* ");
            End();
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
            End();
        }

        public static void LoopQ3()
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                    Console.Write("* ");
                Console.WriteLine("");
            }
            End();
        }

        public static void LoopQ4()
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 5; j++)
                    Console.Write("* ");
                Console.WriteLine("");
            }
            End();
        }

        public static void LoopQ5()
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 20; j++)
                    Console.Write("* ");
                Console.WriteLine("");
            }
            End();
        }

        public static void LoopQ6()
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                    Console.Write($"{j} ");
                Console.WriteLine("");
            }
            End();
        }

        public static void LoopQ7()
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                    Console.Write($"{i} ");
                Console.WriteLine("");
            }
            End();
        }

        public static void LoopQ8()
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j <= i; j++)
                    Console.Write($"{j} ");
                Console.WriteLine("");
            }
            End();
        }

        public static void LoopQ9()
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
            End();
        }

        public static void LoopQ10()
        {
            for (int i = 1; i < 10; i++)
            {
                for (int j = i; j < i * 10 ; j+=i)
                    if (j < 10)
                        Console.Write($" {j} ");
                    else
                        Console.Write($"{j} ");
                Console.WriteLine("");
            }
            End();
        }

        public static void LoopQ11()
        {
            for (int i = 1; i < 10; i++)
            {
                // Spaces
                for (int l = 1; l < 10 - i; l++)
                    Console.Write("  ");

                // Counting Up
                for (int j = 1; j <= i; j++)
                    Console.Write($"{j} ");

                // Counting Down
                for (int k = i - 1; k > 0; k--)
                    Console.Write($"{k} ");

                Console.WriteLine("");
            }
            End();
        }

        public static void LoopQ12()
        {
            for (int i = 1; i < 10; i++)
            {
                //Top Half
                // Spaces
                for (int l = 1; l < 10 - i; l++)
                    Console.Write("  ");

                // Counting Up
                for (int j = 1; j <= i; j++)
                    Console.Write($"{j} ");

                // Counting Down
                for (int k = i - 1; k > 0; k--)
                    Console.Write($"{k} ");

                Console.WriteLine("");
            }

            //Bottom Half
            for (int i = 1; i < 10; i++)
            {
                // Spaces
                for (int k = 0; k < i; k++)
                    Console.Write("  ");
                // Numbers Up
                for (int j = 1; j < 10 - i; j++)
                    Console.Write($"{j} ");
                // Numbers Down
                for (int l = 8 - i; l > 0;  l--)
                    Console.Write($"{l} ");

                Console.WriteLine("");
            }

            End();
        }

        public static void End()
        {
            Console.WriteLine();
            Console.WriteLine("Hit ENTER to continue");
            Console.ReadLine();
        }

        // Menu Loop and Choice Input
        public static void Menu()
        {
            string choice = "";
            int question;
            while (choice != "q")
            {
                Console.Clear(); // Optional
                Console.WriteLine("Which of the advanced looping problems (1 - 12) would you like to run?");
                Console.WriteLine("Q - Quit");
                Console.WriteLine();
                choice = Console.ReadLine().ToLower().Trim();
                Console.WriteLine();
                Int32.TryParse(choice, out question);
                ResolveChoice(question);
            }
        }

        // Calls the method correcponding to the choice
        public static void ResolveChoice(int selection)
        {
            switch (selection)
            {
                case 0:
                    Console.WriteLine("Thanks for playing!");
                    break;
                case 1:
                    LoopQ1();
                    break;
                case 2:
                    LoopQ2();
                    break;
                case 3:
                    LoopQ3();
                    break;
                case 4:
                    LoopQ4();
                    break;
                case 5:
                    LoopQ5();
                    break;
                case 6:
                    LoopQ6();
                    break;
                case 7:
                    LoopQ7();
                    break;
                case 8:
                    LoopQ8();
                    break;
                case 9:
                    LoopQ9();
                    break;
                case 10:
                    LoopQ10();
                    break;
                case 11:
                    LoopQ11();
                    break;
                case 12:
                    LoopQ12();
                    break;
                default:
                    Console.WriteLine("Invalid Choice");
                    break;
            }
        }

    }
}
