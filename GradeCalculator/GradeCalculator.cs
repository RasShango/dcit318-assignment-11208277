using System;

class GradeCalculator
{
    static void Main()
    {
        Console.Write("Enter your grade (0-100): ");

        string input = Console.ReadLine();
        int grade;

        if (int.TryParse(input, out grade))
        {
            if (grade < 0 || grade > 100)
            {
                Console.WriteLine("Please enter a valid grade between 0 and 100.");
            }
            else
            {
                char letter;

                if (grade >= 90)
                    letter = 'A';
                else if (grade >= 80)
                    letter = 'B';
                else if (grade >= 70)
                    letter = 'C';
                else if (grade >= 60)
                    letter = 'D';
                else
                    letter = 'F';

                Console.WriteLine($"Your letter grade is: {letter}");
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a numerical value.");
        }
    }
}
