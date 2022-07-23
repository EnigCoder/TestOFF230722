using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static int N_digits;
        static int[] Digits;

        public static void Main(string[] args)
        {
            Console.WriteLine("Enter N");
            N_digits = Convert.ToInt16(Console.ReadLine());
            while (true)
            {
                if (N_digits >= 5 && N_digits <= 10)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Enter N again");
                    N_digits = Convert.ToInt16(Console.ReadLine());


                }

            }
            Digits = new int[N_digits];
            Console.WriteLine("Enter numbers of N");

            for (int i = 0; i < N_digits; i++)
            {
                Digits[i] = Convert.ToInt16(Console.ReadLine());
            }
            Console.WriteLine("");

            Menu();
            Console.ReadKey();

        }
        public static void Menu()
        {
        mark: ColorRedNumberAgain();
            ConsoleKeyInfo key = new ConsoleKeyInfo();
            key = Console.ReadKey();

            switch (key.Key)
            {
                case ConsoleKey.UpArrow:
                mark2: ColorRedShowResult();
                    ConsoleKeyInfo key_updouble = new ConsoleKeyInfo();
                    key_updouble = Console.ReadKey();
                    switch (key_updouble.Key)
                    {
                        case ConsoleKey.UpArrow:
                            ColorRedSort();
                            ConsoleKeyInfo key_uptriple = new ConsoleKeyInfo();
                            key_uptriple = Console.ReadKey();
                            switch (key_uptriple.Key)
                            {
                                case ConsoleKey.UpArrow:
                                    goto mark;
                                case ConsoleKey.DownArrow:
                                    goto mark2;
                                case ConsoleKey.Enter:
                                    Sort();
                                    break;
                            }
                            break;

                        case ConsoleKey.DownArrow:
                            goto mark;
                        case ConsoleKey.Enter:
                            ShowResult();
                            break;
                    }
                    break;

                case ConsoleKey.DownArrow:
                mark3: ColorRedSort();
                    ConsoleKeyInfo key_downdouble = new ConsoleKeyInfo();
                    key_downdouble = Console.ReadKey();
                    switch (key_downdouble.Key)
                    {
                        case ConsoleKey.DownArrow:
                            ColorRedShowResult();
                            ConsoleKeyInfo key_downtriple = new ConsoleKeyInfo();
                            key_downtriple = Console.ReadKey();
                            switch (key_downtriple.Key)
                            {
                                case ConsoleKey.DownArrow:
                                    goto mark;

                                case ConsoleKey.UpArrow:
                                    goto mark3;

                                case ConsoleKey.Enter:
                                    ShowResult();
                                    break;

                            }
                            break;
                        case ConsoleKey.UpArrow:
                            goto mark;
                        case ConsoleKey.Enter:
                            Sort();
                            break;
                    }
                    break;
                case ConsoleKey.Enter:
                    EnterNumberAgain();
                    break;


            }

        }
        public static void Sort()
        {
            for (int i = 0; i < Digits.Length; i++)
                for (int j = i + 1; j < Digits.Length; j++)
                {
                    if (Digits[i] > Digits[j])
                    {
                        int temp = Digits[i];
                        Digits[i] = Digits[j];
                        Digits[j] = temp;
                    }



                }
            Console.WriteLine("Your list have been sorted.");
            Console.ReadKey();
            Menu();



        }
        public static void EnterNumberAgain()
        {
            Console.Clear();
            Console.WriteLine("Enter numbers of N");
            for (int i = 0; i < N_digits; i++)
            {
                Digits[i] = Convert.ToInt16(Console.ReadLine());
            }
            Console.ReadKey();
            Menu();
        }
        public static void ShowResult()
        {
            if (N_digits == 5)
            {
                Console.WriteLine("+-----+-----+-----+-----+-----+");
                Console.WriteLine($"| {Digits[1]}    |{Digits[2]}   | {Digits[3]}   |  {Digits[4]}   | {Digits[5]}    | ");
                Console.WriteLine("+-----+-----+-----+-----+-----+");
            }
            if (N_digits == 6)
            {
                Console.WriteLine("+-----+-----+-----+-----+-----+-----+");
                Console.WriteLine($"| {Digits[1]}   |{Digits[2]}    | {Digits[3]}   | {Digits[4]}    | {Digits[5]}   |{Digits[6]}    |");
                Console.WriteLine("+-----+-----+-----+-----+-----+-----+");
            }
            if (N_digits == 7)
            {
                Console.WriteLine("+-----+-----+-----+-----+-----+-----+-----+");
                Console.WriteLine($"|{Digits[1]}  | {Digits[2]}   | {Digits[3]}    |  {Digits[4]}    |  {Digits[5]}    | {Digits[6]}  | {Digits[7]}    |");
                Console.WriteLine("+-----+-----+-----+-----+-----+-----+-----+");
            }
            if (N_digits == 8)
            {
                Console.WriteLine("+-----+-----+-----+-----+-----+-----+-----+-----+");
                Console.WriteLine($"|{Digits[1]}    |{Digits[2]}   | {Digits[3]}    | {Digits[4]}   | {Digits[5]}   | {Digits[6]}   |{Digits[7]}    | {Digits[8]}   |");
                Console.WriteLine("+-----+-----+-----+-----+-----+-----+-----+-----+");
            }
            if (N_digits == 9)
            {
                Console.WriteLine("+-----+-----+-----+-----+-----+-----+-----+-----+-----+");
                Console.WriteLine($"|{Digits[1]}   | {Digits[2]}    | {Digits[3]}  | {Digits[4]}   | {Digits[5]}   | {Digits[6]}     | {Digits[7]}   |{Digits[8]}   | {Digits[9]}    |");
                Console.WriteLine("+-----+-----+-----+-----+-----+-----+-----+-----+-----+");
            }
            if (N_digits == 10)
            {
                Console.WriteLine("+-----+-----+-----+-----+-----+-----+-----+-----+-----+-----+");
                Console.WriteLine($"|{Digits[1]}    |{Digits[2]}  | {Digits[3]}   | {Digits[4]}   | {Digits[5]}   |{Digits[6]}    |{Digits[7]}   | {Digits[8]}   | {Digits[9]}     | {Digits[10]}   |");
                Console.WriteLine("+-----+-----+-----+-----+-----+-----+-----+-----+-----+-----+");
            }
            Console.ReadKey();
            Menu();



        }
        public static void ColorRedNumberAgain()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("1. Enter Number again");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("2. Sort");
            Console.WriteLine("3. Show Result");
        }
        public static void ColorRedSort()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("1. Enter Number again");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("2. Sort");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("3. Show Result");
        }
        public static void ColorRedShowResult()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("1. Enter Number again");
            Console.WriteLine("2. Sort");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("3. Show Result");
        }

    }
}
