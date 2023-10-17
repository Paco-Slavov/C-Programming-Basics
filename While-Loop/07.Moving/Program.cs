﻿using System;

namespace Moving
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int legth = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            double freeSpace = width * legth * height;
            string input = Console.ReadLine();

            while (input != "Done")
            {
                double currentBoxes = double.Parse(input);

                freeSpace = freeSpace - currentBoxes;


                if (freeSpace < 0)
                {
                    Console.WriteLine("No more free space! You need " + Math.Abs(freeSpace) + " Cubic meters more.");
                    return;
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(freeSpace + " Cubic meters left.");
        }
    }
}
