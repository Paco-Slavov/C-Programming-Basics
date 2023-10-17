using System;

namespace Exam6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int firstNum = 0;
            int secondNum = 0;
            int thirdNum = 0;

            firstNum = num % 10; // първото число се брои за трето
            secondNum = num / 10 % 10; // второто си остава второ
            thirdNum = num / 100; // третото се пише за първо
            for (int x = 1; x <= firstNum; x++)
            {
                for (int y = 1; y <= secondNum; y++)
                {
                    for (int z = 1; z <= thirdNum; z++)
                    {
                        int result = x * y * z;
                        Console.WriteLine($"{x} * {y} * {z} = {result}");
                    }
                }
            }
        }
    }
}
