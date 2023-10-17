using System;

namespace Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Четем от конзолата:
            // пари, необходими за екскурзията и спестявания
            double neededMoney = double.Parse(Console.ReadLine());
            double avaliableMoney = double.Parse(Console.ReadLine());

            //2.1. Създаваме 2 брояча: за общия брой дни; поредни дни харчене
            int daysCount = 0;
            int spendCount = 0;

            //2.2. Създаваме променливи за типа дейстие и за сумата
            string input; //"spend"/"save"
            double money;

            //3. Създаваме цикъл, който да се изпълнява, докато спести достатъчно
            while (avaliableMoney < neededMoney)
            {
                // четем вид действие ("spend" и "save")
                input = Console.ReadLine();
                // четем сума, която харчи/спестява
                money = double.Parse(Console.ReadLine());

                //увеличаваме брояча на общия брой дни
                daysCount++;

                //ако e "save":
                if (input == "save")
                {
                    // => добавяме сумата към спестяванията
                    avaliableMoney += money;
                    // => нулираме брояча на поредните дни харчене
                    spendCount = 0;
                }
                else //ако е "spend"
                {
                    // => изваждаме сумата от спестяванията
                    avaliableMoney -= money;
                    // => проверяваме дали спестяванията <0 
                    if (avaliableMoney < 0)
                    {
                        // ==> трябва да направим спестяванията=0 
                        avaliableMoney = 0;
                    }
                    // => увеличаваме брояча на поредните дни харчене
                    spendCount++;
                    // ==> дали поредните дни харчене == 5
                    if (spendCount == 5)
                    {
                        // ===> отпечатваме и спираме изпълнението на цикъла:
                        Console.WriteLine("You can't save the money.");
                        Console.WriteLine(daysCount);
                        break;
                    }
                }
            }

            //4. Проверяваме дали е успяла да спести достатъчно
            if (avaliableMoney >= neededMoney)
            {
                //=> ако е успяла, отпечатваме:
                Console.WriteLine($"You saved the money for {daysCount} days.");

            }

        }
    }
}