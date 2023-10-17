using System;

namespace _10.Invalid_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double validNumber = double.Parse(Console.ReadLine());

            if (validNumber >= 100 && validNumber <= 200 || validNumber == 0)
            {

            }
            else
            {
                Console.WriteLine("invalid");
            }
        }
    }
}
