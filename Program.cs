using System;

class Program
{
    static void Main(string[] args)
    {
        // Step 3: Declare Variables
        double length, width, area;

        // Step 4: Ask the user for inputs
        Console.Write("Enter the length of the rectangle: ");
        length = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the width of the rectangle: ");
        width = Convert.ToDouble(Console.ReadLine());

        // Step 5: Calculate the Area
        area = length * width;

        // Step 6: Display the Result
        Console.WriteLine($"The area of the rectangle is {area}");

        // Step 7: Wait for the user to close the console
        Console.WriteLine("Press any key to exit.");
        Console.ReadKey();
    }
}
