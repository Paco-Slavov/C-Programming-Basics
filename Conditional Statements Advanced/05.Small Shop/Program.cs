﻿using System;

namespace _05.Small_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            string town = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());

            double price = 0;

            switch (town)
            {
                case "Sofia":
                    switch (product)
                    {
                        case "coffee":
                            price = 0.50;
                            break;
                        case "water":
                            price = 0.80;
                            break;
                        case "beer":
                            price = 1.20;
                            break;
                        case "sweets":
                            price = 1.45;
                            break;
                        case "peanuts":
                            price = 1.60;
                            break;
                    }
                    break;
            }
            switch (town)
            {
                case "Plovdiv":
                    switch (product)
                    {
                        case "coffee":
                            price = 0.40;
                            break;
                        case "water":
                            price = 0.70;
                            break;
                        case "beer":
                            price = 1.15;
                            break;
                        case "sweets":
                            price = 1.30;
                            break;
                        case "peanuts":
                            price = 1.50;
                            break;
                    }
                    break;
            }
            switch (town)
            {
                case "Varna":
                    switch (product)
                    {
                        case "coffee":
                            price = 0.45;
                            break;
                        case "water":
                            price = 0.70;
                            break;
                        case "beer":
                            price = 1.10;
                            break;
                        case "sweets":
                            price = 1.35;
                            break;
                        case "peanuts":
                            price = 1.55;
                            break;
                    }
                    break;
            }

            Console.WriteLine(quantity * price);
        }
    }
}
