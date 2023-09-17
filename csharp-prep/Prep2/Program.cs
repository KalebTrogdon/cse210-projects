using System;

namespace Prep2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your grade percentage: ");
            string input = Console.ReadLine();

            int percentage = int.Parse(input);
            string letter;
            
            if (percentage >= 90)
            {
                letter = "A";
            }
            else if (percentage >= 80)
            {
                letter = "B";
            }
            else if (percentage >= 70)
            {
                letter = "C";
            }
            else if (percentage >= 60)
            {
                letter = "D";
            }
            else
            {
                letter = "F";
            }

            if (percentage >= 70)
            {
                Console.WriteLine("Congratulations! You passed the course.");
            }
            else
            {
                Console.WriteLine("Better luck next time. Keep working hard.");
            }

            string sign = "";

            if (percentage % 10 >= 7)
            {
                sign = "+";
            }
            else if (percentage % 10 < 3)
            {
                sign = "-";
            }

            string finalGrade = letter + sign;

            Console.WriteLine($"Your final grade is {finalGrade}");
        }
    }
}
