using System;

namespace _12.Trade_Commissions
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string town = Console.ReadLine();
            double sales = double.Parse(Console.ReadLine());
            double percent = 0;

            if (town == "Sofia")
            {
                if (0 <= sales && sales <= 500)
                    percent = 0.05;
                else if (500 < sales && sales <= 1000)
                    percent = 0.07;
                else if (1000 < sales && sales <= 10000)
                    percent = 0.08;
                else if (sales > 10000)
                    percent = 0.12;
                else
                    Console.WriteLine("error");
            }
            else if (town == "Varna")
            {
                if (0 <= sales && sales <= 500)
                    percent = 0.045;
                else if (500 < sales && sales <= 1000)
                    percent = 0.075;
                else if (1000 < sales && sales <= 10000)
                    percent = 0.10;
                else if (sales > 10000)
                    percent = 0.13;
                else
                    Console.WriteLine("error");
            }
            else if (town == "Plovdiv")
            {
                if (0 <= sales && sales <= 500)
                    percent = 0.055;
                else if (500 < sales && sales <= 1000)
                    percent = 0.08;
                else if (1000 < sales && sales <= 10000)
                    percent = 0.12;
                else if (sales > 10000)
                    percent = 0.145;
                else
                    Console.WriteLine("error");
            }
            else
                Console.WriteLine("error");

            double commission = sales * percent;
            if (commission != 0)
                Console.WriteLine($"{commission:f2}");
        }
    }
}