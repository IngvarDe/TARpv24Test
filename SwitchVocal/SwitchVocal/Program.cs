﻿namespace SwitchVocal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta täht ja vajuta enter");

            string ch = Console.ReadLine();

            switch (ch)
            {
                case "a":
                    Console.WriteLine("Vokaal a");
                    break;

                case "e":
                    Console.WriteLine("Vokaal a");
                    break;

                case "i":
                    Console.WriteLine("Vokaal a");
                    break;

                default:
                    Console.WriteLine("Ei ole vokaal e täishäälik");
                    break;
            }
        }
    }
}
