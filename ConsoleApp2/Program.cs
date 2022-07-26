﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ConsoleApp2
{
    internal class Program
    {
        static int N_digits;
        static int[] Digits;
        static void Main(string[] args)
        {
            EnterNumber();
            ColorRedNumber();
            key(Digits, N_digits);
            
    
               
               
            

        }
        
        public static void EnterNumber()
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
        }
        public static void SortUp(int[] Digits, int N_digits)
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
            Console.WriteLine("SortUp Successfully!!!");
        }
        public static void SortDown(int[] Digits, int N_digits)
        {
            for (int i = 0; i < Digits.Length; i++)
                for (int j = i + 1; j < Digits.Length; j++)
                {
                    if (Digits[i] < Digits[j])
                    {
                        int temp = Digits[i];
                        Digits[i] = Digits[j];
                        Digits[j] = temp;
                    }
                }
            Console.WriteLine("SortDown Successfully!!!");
        }
        public static void ShowResult(int[] Digits, int N_digits)
        {
            if (N_digits == 5)
            {
                Console.WriteLine("+-----+-----+-----+-----+-----+");
                Console.WriteLine($"| {Digits[0]}    |{Digits[1]}   | {Digits[2]}   |  {Digits[3]}   | {Digits[4]}    | ");
                Console.WriteLine("+-----+-----+-----+-----+-----+");
            }
            if (N_digits == 6)
            {
                Console.WriteLine("+-----+-----+-----+-----+-----+-----+");
                Console.WriteLine($"| {Digits[0]}   |{Digits[1]}    | {Digits[2]}   | {Digits[3]}    | {Digits[4]}   |{Digits[5]}    |");
                Console.WriteLine("+-----+-----+-----+-----+-----+-----+");
            }
            if (N_digits == 7)
            {
                Console.WriteLine("+-----+-----+-----+-----+-----+-----+-----+");
                Console.WriteLine($"|{Digits[0]}  | {Digits[1]}   | {Digits[2]}    |  {Digits[3]}    |  {Digits[4]}    | {Digits[5]}  | {Digits[6]}    |");
                Console.WriteLine("+-----+-----+-----+-----+-----+-----+-----+");
            }
            if (N_digits == 8)
            {
                Console.WriteLine("+-----+-----+-----+-----+-----+-----+-----+-----+");
                Console.WriteLine($"|{Digits[0]}    |{Digits[1]}   | {Digits[2]}    | {Digits[3]}   | {Digits[4]}   | {Digits[5]}   |{Digits[6]}    | {Digits[7]}   |");
                Console.WriteLine("+-----+-----+-----+-----+-----+-----+-----+-----+");
            }
            if (N_digits == 9)
            {
                Console.WriteLine("+-----+-----+-----+-----+-----+-----+-----+-----+-----+");
                Console.WriteLine($"|{Digits[0]}   | {Digits[1]}    | {Digits[2]}  | {Digits[3]}   | {Digits[4]}   | {Digits[5]}     | {Digits[6]}   |{Digits[7]}   | {Digits[8]}    |");
                Console.WriteLine("+-----+-----+-----+-----+-----+-----+-----+-----+-----+");
            }
            if (N_digits == 10)
            {
                Console.WriteLine("+-----+-----+-----+-----+-----+-----+-----+-----+-----+-----+");
                Console.WriteLine($"|{Digits[0]}    |{Digits[1]}  | {Digits[2]}   | {Digits[3]}   | {Digits[4]}   |{Digits[5]}    |{Digits[6]}   | {Digits[7]}   | {Digits[8]}     | {Digits[9]}   |");
                Console.WriteLine("+-----+-----+-----+-----+-----+-----+-----+-----+-----+-----+");
            }




        }
        public static void DemoSortUp(int[]Digits, int N_digits)
        {
            ShowResult(Digits, N_digits);
            for (int i = 0; i < Digits.Length; i++)
                for (int j = i + 1; j < Digits.Length; j++)
                {
                    if (Digits[i] > Digits[j])
                    {
                        int temp = Digits[i];
                        Digits[i] = Digits[j];
                        Digits[j] = temp;
                        ShowResult(Digits, N_digits);
                        Thread.Sleep(1000);
                    }
                }

        }
        public static void Exit() 
        {
          Environment.Exit(0);  
        }
        public static void key(int[] Digits,int N_digits)
        {  
            
            int x = 0;
            ConsoleKeyInfo key = new ConsoleKeyInfo();
            while (true) 
            {
                key = Console.ReadKey(true);
                switch (key.Key)
                {
                    case ConsoleKey.UpArrow:
                        x--;
                        break;
                    case ConsoleKey.DownArrow:
                        x++;
                        break;
                    case ConsoleKey.Enter:
                        if (x == 0)
                            EnterNumber();
                        if (x == 1)
                            SortUp(Digits, N_digits);
                        if (x == 2)
                            SortDown(Digits,N_digits);
                        if (x == 3)
                            ShowResult(Digits, N_digits);
                        if (x == 4)
                            DemoSortUp(Digits, N_digits);
                        if (x == 5)
                        {
                            Console.WriteLine("Goodbye!");
                            Thread.Sleep(1000);
                            Exit();

                        }
                        break;
                }

                if (x < 0)
                    x = 5;
                if (x > 5)
                    x = 0;
                DrawColor(x);
            }              
        }
        public static void DrawColor(int x)
        {
            if (x == 0)
                ColorRedNumber();
            if (x == 1)
                ColorRedSortUp();
            if (x == 2)
                ColorRedSortDown();
            if (x == 3)
                ColorRedShowResult();
            if (x == 4)
                ColorRedDeMoSortUp();
            if (x == 5)
                ColorRedExit();

        }
        public static void ColorRedNumber()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("1. Enter Number again");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("2. SortUp");
            Console.WriteLine("3. SortDown");
            Console.WriteLine("4. Show Result");
            Console.WriteLine("5. DemoSortup");
            Console.WriteLine("6. Exit");
        }
        public static void ColorRedSortUp()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("1. Enter Number again");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("2. SortUp");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("3. SortDown");
            Console.WriteLine("4. Show Result");
            Console.WriteLine("5. DemoSortup");
            Console.WriteLine("6. Exit");
        }
        public static void ColorRedSortDown()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("1. Enter Number again");
            Console.WriteLine("2. SortUp");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("3. SortDown");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("4. Show Result");
            Console.WriteLine("5. DemoSortup");
            Console.WriteLine("6. Exit");
        }
        public static void ColorRedShowResult()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("1. Enter Number again");
            Console.WriteLine("3. SortDown");
            Console.WriteLine("2. SortUp");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("4. Show Result");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("5. DemoSortup");
            Console.WriteLine("6. Exit");
        }
        public static void ColorRedDeMoSortUp() 
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("1. Enter Number again");
            Console.WriteLine("3. SortDown");
            Console.WriteLine("2. SortUp");
            Console.WriteLine("4. Show Result");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("5. DemoSortup");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("6. Exit");
        }
        public static void ColorRedExit()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("1. Enter Number again");
            Console.WriteLine("3. SortDown");
            Console.WriteLine("2. SortUp");
            Console.WriteLine("4. Show Result");
            Console.WriteLine("5. DemoSortup");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("6. Exit");
        }
       

    }
}
