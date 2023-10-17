using System;

namespace Exam

{

    class Program

    {
        static void Main(string[] args)

        {
            int hallPrice = int.Parse(Console.ReadLine());
            double statuettesPrice = hallPrice * 0.70;
            double cateringPrice = statuettesPrice * 0.85;
            double music = cateringPrice / 2.0;
            double totalSum = hallPrice + statuettesPrice + cateringPrice + music;

            Console.WriteLine($"{totalSum:f2}");
        }
    }
}