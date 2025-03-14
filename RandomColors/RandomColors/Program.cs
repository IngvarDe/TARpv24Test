﻿namespace RandomColors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Suvalised värvid!");

            //kasutada switchi
            //kuvab iga kord suvalised v'rvid
            //Red, Green, Blue, White, Orange
            //iga v'rvi puhul n'itab vastava v'rviga konsooli
            

            for (int i = 0; i < 1000; i++)
            {
                Color c = (Color)(new Random()).Next(0, 5);

                switch (c)
                {
                    case Color.Red:
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.Clear();
                        Console.WriteLine("Red");
                        Console.Beep();
                        break;

                    case Color.Green:
                        Console.BackgroundColor = ConsoleColor.Green;
                        Console.Clear();
                        Console.WriteLine("Green");
                        Console.Beep();
                        break;

                    case Color.Blue:
                        Console.BackgroundColor = ConsoleColor.Blue;
                        Console.Clear();
                        Console.WriteLine("Blue");
                        Console.Beep();
                        break;

                    case Color.White:
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.Clear();
                        Console.WriteLine("White");
                        Console.Beep();
                        break;

                    case Color.Orange:
                        Console.BackgroundColor = ConsoleColor.DarkYellow;
                        Console.Clear();
                        Console.WriteLine("DarkYellow");
                        Console.Beep();
                        break;

                    default:
                        break;
                }
            }


        }

        public enum Color
        {
            Red, Green, Blue, White, Orange
        }
    }
}
