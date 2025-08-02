using System;

class TicketPriceCalculator
{
    static void Main()
    {
        Console.Write("Enter your age: ");

        string input = Console.ReadLine();
        int age;

        if (int.TryParse(input, out age))
        {
            if (age < 0)
            {
                Console.WriteLine("Age cannot be negative.");
            }
            else
            {
                decimal ticketPrice;

                if (age <= 12 || age >= 65)
                {
                    ticketPrice = 7.00m;
                }
                else
                {
                    ticketPrice = 10.00m;
                }

                Console.WriteLine($"Your ticket price is: GHC{ticketPrice}");
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid age.");
        }
    }
}
