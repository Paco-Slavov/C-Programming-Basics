using System;

namespace _04._Movie_Ratings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string maxRatingMovieName = string.Empty;
            string minRatingMovieName = string.Empty;
            double maxRating = double.MinValue;
            double minRating = double.MaxValue;
            double totalRating = 0;

            for (int i = 1; i <=n ; i++)
            {
                string movieName = Console.ReadLine();
                double movieRating = double.Parse(Console.ReadLine());

                if (movieRating > maxRating)
                {
                    maxRatingMovieName = movieName;
                    maxRating = movieRating;
                }
                if (movieRating < minRating)
                {
                    minRatingMovieName = movieName;
                    minRating = movieRating;
                }
                totalRating += movieRating;
            }
            double averageRating = totalRating / n;

            Console.WriteLine($"{maxRatingMovieName} is with highest rating: {maxRating:f1}");
            Console.WriteLine($"{minRatingMovieName} is with lowest rating: {minRating:f1}");
            Console.WriteLine($"Average rating: {averageRating:f1}");
        }
    }
}
