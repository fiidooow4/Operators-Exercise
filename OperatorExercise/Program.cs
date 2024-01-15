
using System;

namespace OperatorsExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Create two integer variables
            int a = 17;
            int b = 4;

            // Addition
            int sum = a + b;
            Console.WriteLine($"{a} + {b} is {sum}");

            // Subtraction
            int difference = a - b;
            Console.WriteLine($"{a} - {b} is {difference}");

            // Multiplication
            int product = a * b;
            Console.WriteLine($"{a} * {b} is {product}");

            // Division and Modulus
            int quotient = a / b;
            int remainder = a % b;
            Console.WriteLine($"{a}/{b} is {quotient} remainder {remainder}");

            // Exercise 2 - Calculate Area of a Circle
            Console.Write("Enter the radius of the circle: ");
            double radius = double.Parse(Console.ReadLine());

            // Call the AreaOfCircle method and print the result
            double v = AreaOfCircle(radius);
            double area = v;
            Console.WriteLine($"The area of the circle with radius {radius} is: {area}");
        }

        // Exercise 2 - Area of Circle Method
        static double AreaOfCircle(double radius)
        {
            return Math.PI * Math.Pow(radius, 2);
        }
    }
}

class Program
{
    static void Main()
    {
        // Allow the user to input the radius
        Console.WriteLine("What is the radius of your circle?");
        var radius = double.Parse(Console.ReadLine());

        // Calculate and display the area of the circle
        var area = AreaOfCircle(radius);
        Console.WriteLine($"The area of a circle with a radius of {radius} is {area}");

        // Thought Exercise
        var i = 3;
        var j = 4;
        var k = ++i * j++;

        Console.WriteLine(k); // outputs 16
        Console.ReadLine(); // To keep the console window open
    }

    // Method to calculate the area of a circle
    static double AreaOfCircle(double radius)
    {
        return Math.PI * Math.Pow(radius, 2);
    }
}


