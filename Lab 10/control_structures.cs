using System;

class Program
{
    static void Main()
    {
        try
        {
            // Accept user input
            Console.Write("Enter first number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            // Arithmetic operations
            int sum = num1 + num2;
            int difference = num1 - num2;
            int product = num1 * num2;
            double quotient = num2 != 0 ? (double)num1 / num2 : double.NaN;

            // Check if sum is even or odd
            string sumType = (sum % 2 == 0) ? "even" : "odd";

            // Display results
            Console.WriteLine($"Sum: {sum} ({sumType})");
            Console.WriteLine($"Difference: {difference}");
            Console.WriteLine($"Product: {product}");
            Console.WriteLine($"Quotient: {quotient}");
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid input! Please enter numeric values.");
        }
    }
}
