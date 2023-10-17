using System;
using System.Runtime.ConstrainedExecution;
using System.Xml.Schema;

namespace Exam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int dancers = int.Parse(Console.ReadLine());
            double score = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string place = Console.ReadLine();
            double moneyCosts = 0.0;
            double moneyReward = 0.0;
            if (place == "Bulgaria")
            {
                if (season == "summer")
                {
                    moneyReward = dancers * score;
                    moneyCosts = moneyReward * 0.05;
                }
                else if (season == "winter")
                {
                    moneyReward = dancers * score;
                    moneyCosts = moneyReward * 0.08;
                }
            }
            else if (place == "Abroad")
            {
                if (season == "summer")
                {
                    moneyReward += (dancers * score);
                    moneyReward += moneyReward * 0.5;
                    moneyCosts = moneyReward * 0.10;
                }
                else if (season == "winter")
                {
                    moneyCosts = moneyReward * 0.15;
                }
            }
            double totalMoney = moneyReward - moneyCosts;
            double donation = totalMoney * 0.75;
            double totalMoneyAfterDonation = totalMoney - donation;
            double moneyLeftForDancers = totalMoneyAfterDonation / dancers;
            Console.WriteLine($"Charity - {donation:f2}");
            Console.WriteLine($"Money per dancer - {moneyLeftForDancers:f2}");
        }
    }
}

