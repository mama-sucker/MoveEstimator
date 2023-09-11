// Module 2 = Excersise 2.2 
// Addison Roy 
// Move Estimator
using System;

class Program
{
    static void Main()
    {
        const double BaseRate = 200;
        const double PerHourRate = 150;
        const double PerMileRate = 2;

        Console.Write("Simple move estimator calculator\n");
        Console.Write("Enter how many hours for the job: ");
        string hoursInput = Console.ReadLine();

        Console.Write("Enter the number of miles traveled in the move: ");
        string milesInput = Console.ReadLine();

        if (int.TryParse(hoursInput, out int hours) && int.TryParse(milesInput, out int miles))
        {
            double totalCost = BaseRate + (hours * PerHourRate) + (miles * PerMileRate);

            Console.WriteLine($"Total cost: ${totalCost}");
        }
        else
        {
            Console.WriteLine("Enter a real number and try again!");
        }
    }
}

