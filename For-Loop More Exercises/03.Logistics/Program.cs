using System;

namespace _03.Logistics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfGoods = int.Parse(Console.ReadLine());
            int totalTonnage = 0;
            int priceOfMicrobus = 200;
            int priceOfTruck = 175;
            int priceOfTrain = 120;
            double average = 0;

            double tonnageOfMicrobus = 0;
            double tonnageOfTruck = 0;
            double tonnageOfTrain = 0;

            for (int i = 0; i < numberOfGoods; i++)
            {
                int cargoTonnage = int.Parse(Console.ReadLine());

                totalTonnage += cargoTonnage;

                if (cargoTonnage <= 3)
                {
                    tonnageOfMicrobus += cargoTonnage;
                }
                else if (cargoTonnage >= 4 && cargoTonnage <= 11)
                {
                    tonnageOfTruck += cargoTonnage;
                }
                else if (cargoTonnage >= 12)
                {
                    tonnageOfTrain += cargoTonnage;
                }
            }
            average = (tonnageOfMicrobus * priceOfMicrobus + tonnageOfTruck * priceOfTruck + tonnageOfTrain * priceOfTrain) / 25;
            Console.WriteLine($"{average:f2}");
            Console.WriteLine($"{tonnageOfMicrobus / totalTonnage * 100:f2}%");
            Console.WriteLine($"{tonnageOfTruck / totalTonnage * 100:f2}%");
            Console.WriteLine($"{tonnageOfTrain / totalTonnage * 100:f2}%");
        }
    }
}
