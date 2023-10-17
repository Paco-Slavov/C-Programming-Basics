using System;
using System.Runtime.Intrinsics.X86;

namespace _04.Sum_of_Two_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int from = int.Parse(Console.ReadLine());
            int to = int.Parse(Console.ReadLine());
            int magicNumber = int.Parse(Console.ReadLine());

            int combinationN = 0;
            int firstNum = -1;
            int secondNum = -1;
            bool isFound = false;

            for (int n1 = from; n1 <= to; n1++)
            {
                for (int n2 = from; n2 <= to; n2++)
                {
                    combinationN++;
                    if (n1 + n2 == magicNumber)
                    {
                        isFound = true;
                        firstNum = n1;
                        secondNum = n2;
                        break;
                    }
                }
                if (isFound)
                {
                    break;
                }
            }
            if (isFound)
            {
                Console.WriteLine($"Combination N:{combinationN} ({firstNum} + {secondNum} = {magicNumber})");
            }
            else
            {
                Console.WriteLine($"{combinationN} combinations - neither equals {magicNumber}");
            }

        }
    }
}
