using System;

namespace Back_To_The_Past
{
    class BackToThePast
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            int year = int.Parse(Console.ReadLine());

            int age = 18;

            for (int i = 1800; i <= year; i++)
            {
                money -= 12000 * (1 - (i % 2));
                money -= (12000 + (50 * age)) * (i % 2);
                age++;
            }

            if (money >= 0)
            {
                Console.WriteLine($"Yes! He will live a carefree life and will have {money:F2} dollars left.");
            }
            else
            {
                Console.WriteLine($"He will need {-money:F2} dollars to survive.");
            }
        }
    }
}