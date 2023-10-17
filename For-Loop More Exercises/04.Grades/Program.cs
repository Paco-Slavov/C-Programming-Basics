using System;
using System.Runtime.CompilerServices;

namespace _04.Grades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double studentsCount = int.Parse(Console.ReadLine());

            double total = 0;
            double topStudents = 0;
            double between4And5 = 0;
            double between3And4 = 0;
            double failedStudents = 0;

            for (double student = 1; student <= studentsCount; student++)
            {
                double studentGrade = double.Parse(Console.ReadLine());

                if (studentGrade >= 5)
                {
                    topStudents++;
                    total += studentGrade;
                }
                else if (studentGrade >= 4.00 && studentGrade < 5.00)
                {
                    between4And5++;
                    total += studentGrade;
                }
                else if (studentGrade >= 3.00 && studentGrade < 4.00)
                {
                    between3And4++;
                    total += studentGrade;
                }
                else if (studentGrade < 3.00)
                {
                    failedStudents++;
                    total += studentGrade;
                }
            }

            Console.WriteLine($"Top students: {(topStudents / studentsCount) * 100:f2}%");
            Console.WriteLine($"Between 4.00 and 4.99: {(between4And5 / studentsCount) * 100:f2}%");
            Console.WriteLine($"Between 3.00 and 3.99: {(between3And4 / studentsCount) * 100:f2}%");
            Console.WriteLine($"Fail: {(failedStudents / studentsCount) * 100:f2}%");
            Console.WriteLine($"Average: {total / studentsCount:f2}");
        }
    }
}