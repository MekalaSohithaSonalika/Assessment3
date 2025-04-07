using System;

class Program
{
    static void PrintNumbers()
    {
        for (int i = 1; i <= 10; i++)
        {
            Console.Write(i + " ");
        }
        Console.WriteLine();
    }

    static long Factorial(int num)
    {
        long result = 1;
        for (int i = 1; i <= num; i++)
        {
            result *= i;
        }
        return result;
    }

    static void Main()
    {
        // For loop: Print numbers from 1 to 10
        Console.WriteLine("Numbers from 1 to 10:");
        PrintNumbers();

        // While loop: Keep asking for input until "exit"
        string input;
        do
        {
            Console.Write("Enter a number or 'exit' to stop: ");
            input = Console.ReadLine();
        } while (input.ToLower() != "exit");

        // Factorial function
        Console.Write("Enter a number to find factorial: ");
        int num = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"Factorial of {num} is {Factorial(num)}");
    }
}
