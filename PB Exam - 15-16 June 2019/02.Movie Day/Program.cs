using System;

namespace _02.Movie_Day
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int photoTime = int.Parse(Console.ReadLine());
            int sceneCnt = int.Parse(Console.ReadLine());
            int sceneTime = int.Parse(Console.ReadLine());

            double preparingTime = photoTime * 0.15;
            double timeForPhotoScene = sceneCnt * sceneTime;
            double totalTime = timeForPhotoScene + preparingTime;

            if (totalTime < photoTime)
            {
                double timeLeft = photoTime - totalTime;
                Console.WriteLine($"You managed to finish the movie on time! You have {Math.Round(timeLeft)} minutes left!");
            }
            else
            {
                double neededTime = totalTime - photoTime;
                Console.WriteLine($"Time is up! To complete the movie you need {Math.Round(neededTime)} minutes.");
            }
        }
    }
}
