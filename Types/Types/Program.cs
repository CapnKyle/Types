using System;

namespace Types
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = "Kyle";
            int grade = 98;
            char letterGrade = 'A';
            double costOfTuition = 15000.00;

            Console.WriteLine($"{firstName} is a student, {grade} is the grade they earned, which is an {letterGrade} and it cost {costOfTuition} to go to school");

        }
    }
}
