using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter first number: ");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter second number: ");
        int num2 = Convert.ToInt32(Console.ReadLine());

        int sum = num1 + num2;
        int diff = num1 - num2;
        int product = num1 * num2;
        double quotient = num2 != 0 ? (double)num1 / num2 : 0;

        Console.WriteLine($"Sum: {sum}");
        Console.WriteLine($"Difference: {diff}");
        Console.WriteLine($"Product: {product}");
        if (num2 != 0)
            Console.WriteLine($"Quotient: {quotient}");
        else
            try
            {
                Console.WriteLine($"Quotient: {num1 / num2}");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Error: Cannot divide by zero!");
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: Invalid input, please enter numbers.");
            }
        // Check if sum is even or odd
        if (sum % 2 == 0)
            Console.WriteLine("The sum is even.");
        else
            Console.WriteLine("The sum is odd.");
    }
}
