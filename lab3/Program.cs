using System;
class Program
{
    static void Main()
    {
        // Accepting lengths of sides from the user
        Console.Write("Enter the length of side 1: ");
        double side1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the length of side 2: ");
        double side2 = Convert.ToDouble(Console.ReadLine());

        // Creating an instance of the Rectangle class
        Rectangle rectangle = new Rectangle(side1, side2);

        // Displaying the area and perimeter of the rectangle
        Console.WriteLine($"Area of the rectangle: {rectangle.Area}");
        Console.WriteLine($"Perimeter of the rectangle: {rectangle.Perimeter}");

        Console.ReadLine(); // Pause to see the output
    }
}
