using System;

namespace Exam_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine());
            double length = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            double averageHeight = double.Parse(Console.ReadLine());

            double totalVolume = width * length * height;
            double roomVolume = (averageHeight + 0.40) * 2 * 2;
            double space = totalVolume / roomVolume; //Math.Floor

            if (space >= 3 && space <= 10)
            {
                Console.WriteLine($"The spacecraft holds {Math.Floor(space)} astronauts.");
            }
            else if (space < 3)
            {
                Console.WriteLine($"The spacecraft is too small.");
            }
            else if (space > 10)
            {
                Console.WriteLine($"The spacecraft is too big.");
            }
        }
    }
}
