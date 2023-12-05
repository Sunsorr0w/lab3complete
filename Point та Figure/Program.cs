using System;


class Program
{
    static void Main()
    {
        // Creating points for the figure
        Point point1 = new Point(0, 0, "A");
        Point point2 = new Point(0, 4, "B");
        Point point3 = new Point(3, 0, "C");

        // Creating an instance of the Figure class
        Figure figure = new Figure(point1, point2, point3);

        // Calculating and displaying the perimeter of the figure
        figure.CalculatePerimeter();

        Console.ReadLine(); // Pause to see the output
    }
}
