class Point
{
    // Fields for coordinates and name of the point
    private double x;
    private double y;
    private string name;

    // Constructor to initialize the point
    public Point(double x, double y, string name)
    {
        this.x = x;
        this.y = y;
        this.name = name;
    }

    // Properties with accessors to get the coordinates and name
    public double X
    {
        get { return x; }
    }

    public double Y
    {
        get { return y; }
    }

    public string Name
    {
        get { return name; }
    }
}

class Figure
{
    // Array to store points of the figure
    private Point[] points;

    // Constructor for a figure with 3 to 5 points
    public Figure(Point point1, Point point2, Point point3, Point point4 = null, Point point5 = null)
    {
        points = new Point[5];
        points[0] = point1;
        points[1] = point2;
        points[2] = point3;
        points[3] = point4;
        points[4] = point5;
    }

    // Method to calculate the length of a side between two points
    private double GetSideLength(Point A, Point B)
    {
        return Math.Sqrt(Math.Pow(B.X - A.X, 2) + Math.Pow(B.Y - A.Y, 2));
    }

    // Method to calculate the perimeter of the figure
    public void CalculatePerimeter()
    {
        double perimeter = 0.0;

        for (int i = 0; i < points.Length - 1; i++)
        {
            if (points[i] != null && points[i + 1] != null)
            {
                perimeter += GetSideLength(points[i], points[i + 1]);
            }
        }

        Console.WriteLine($"Perimeter of the figure: {perimeter}");
    }
}