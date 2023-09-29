using System;

// Create a class called MathOperations
class MathOperations
{
    // Create a void method called PerformOperation that takes two integers as parameters
    public void PerformOperation(int firstNumber, int secondNumber)
    {
        // Perform a math operation on the first integer (e.g., doubling it)
        int result = firstNumber * 2;

        // Display the second integer to the screen
        Console.WriteLine("Second Number: " + secondNumber);

        // Display the result of the math operation
        Console.WriteLine("Result of the math operation: " + result);
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Instantiate the MathOperations class
        MathOperations math = new MathOperations();

        // Call the PerformOperation method in the class, passing in two numbers (5 and 10)
        math.PerformOperation(5, 10);

        // Call the PerformOperation method in the class, specifying the parameters by name
        math.PerformOperation(firstNumber: 8, secondNumber: 15);

        // Wait for user input to prevent the console window from closing immediately
        Console.ReadLine();
    }
}
