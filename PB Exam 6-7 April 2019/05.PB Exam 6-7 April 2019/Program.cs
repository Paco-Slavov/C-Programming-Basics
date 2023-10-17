using System;

namespace _05.Movie_Ratings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int filmCnt = int.Parse(Console.ReadLine());
            double maxRating = double.MinValue;
            double minRating = double.MaxValue;
            string maxMovie;
            string minMovie;
            double sum = 0;
            string film;

            for (int i = 0; i < filmCnt; i++)
            {
                string movieName = Console.ReadLine();
                double rating = double.Parse(Console.ReadLine());
            
                if (rating > maxRating)
                {
                    maxRating = rating;
                    maxMovie = movieName;
                }  
                if (rating < minRating)
                {
                    minRating = rating;
                    minMovie = movieName;
                }
                sum += rating;
            }
            double average = sum / filmCnt;
        }
    }
}
