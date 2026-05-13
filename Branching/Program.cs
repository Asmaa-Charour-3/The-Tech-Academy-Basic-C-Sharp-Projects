using System;

class Program
{
    static void Main()
    {
        // Opening message that sets the tone for the user experience
        Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

        // Asking for weight and converting the input into a usable number
        Console.WriteLine("Please enter the package weight:");
        decimal weight = Convert.ToDecimal(Console.ReadLine());

        // Early exit if the package is too heavy for the system's limits
        if (weight > 50)
        {
            Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
            return;
        }

        // Gathering width information to begin dimensional evaluation
        Console.WriteLine("Please enter the package width:");
        decimal width = Convert.ToDecimal(Console.ReadLine());

        // Height input to continue building the dimensional profile
        Console.WriteLine("Please enter the package height:");
        decimal height = Convert.ToDecimal(Console.ReadLine());

        // Length input to complete the dimensional set
        Console.WriteLine("Please enter the package length:");
        decimal length = Convert.ToDecimal(Console.ReadLine());

        // Summing dimensions to ensure they fall within acceptable boundaries
        decimal dimensionTotal = width + height + length;

        // If the combined size is excessive, the package cannot be processed
        if (dimensionTotal > 50)
        {
            Console.WriteLine("Package too big to be shipped via Package Express.");
            return;
        }

        // Core pricing formula: volume multiplied by weight, scaled down by 100
        decimal quote = (width * height * length * weight) / 100;

        // Presenting the final cost in a currency-friendly format
        Console.WriteLine($"Your estimated total for shipping this package is: ${quote:F2}");
        Console.WriteLine("Thank you!");
    }
}
