using System;

class TicketPriceCalculator
{
    static void Main()
    {
        // Prompt the user for their age
        Console.Write("Enter your age: ");
        int age = int.Parse(Console.ReadLine());

        // Calculate the ticket price based on age
        int ticketPrice;
        if (age <= 12 || age >= 65)
        {
            ticketPrice = 7;
        }
        else
        {
            ticketPrice = 10;
        }

        // Display the ticket price
        Console.WriteLine("The ticket price is GHC" + ticketPrice);
    }
}
