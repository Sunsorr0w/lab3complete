class Rectangle
{
    // Fields for the lengths of the sides
    private double side1;
    private double side2;

    // Constructor to initialize the lengths of the sides
    public Rectangle(double side1, double side2)
    {
        this.side1 = side1;
        this.side2 = side2;
    }

    // Method to calculate the area of the rectangle
    public double CalculateArea()
    {
        return side1 * side2;
    }

    // Method to calculate the perimeter of the rectangle
    public double CalculatePerimeter()
    {
        return 2 * (side1 + side2);
    }

    // Properties with accessors to get the area and perimeter
    public double Area
    {
        get { return CalculateArea(); }
    }

    public double Perimeter
    {
        get { return CalculatePerimeter(); }
    }
}
