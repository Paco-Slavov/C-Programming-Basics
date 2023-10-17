using System;
using System.Data.SqlTypes;

namespace Exam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double priceForParty = double.Parse(Console.ReadLine());
            int loveMes = int.Parse(Console.ReadLine());
            int rosess = int.Parse(Console.ReadLine());
            int keyKeepers = int.Parse(Console.ReadLine());
            int caricaturess = int.Parse(Console.ReadLine());
            int luckySurprisess = int.Parse(Console.ReadLine());

            double loveMessage = 0.60;
            double rose = 7.20;
            double keyKeeper = 3.60;
            double caricature = 18.20;
            double luckySurprise = 22;
            double priceForHosting;
            double money = 0;

            double totalPrice = (loveMes * loveMessage) + (rosess * rose) + (keyKeepers * keyKeeper) + (caricaturess * caricature) + (luckySurprisess * luckySurprise);

            int totalArticules = loveMes + rosess + keyKeepers + caricaturess + luckySurprisess;
            if (totalArticules >= 25)
            {
                totalPrice = totalPrice * 0.65;
            }
            priceForHosting = totalPrice * 0.10;
            if (totalPrice > priceForParty)
            {
                money = totalPrice - priceForHosting;
                double moneyLeft = money - priceForParty;
                Console.WriteLine($"Yes! {moneyLeft:f2} lv left.");
            }
            else if (totalPrice < priceForParty)
            {
                money = totalPrice - priceForHosting;
                double neededMoney = priceForParty - money;
                Console.WriteLine($"Not enough money! {neededMoney:f2} lv needed.");
            }
        }
    }
}