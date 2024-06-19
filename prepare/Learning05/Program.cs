using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Learning05 World!");

        Square square1 = new("green", 5);
        Console.WriteLine(square1.GetColor());
        Console.WriteLine(square1.GetArea());

        Rectangle rectangle1 = new("blue", 3, 4);
        Console.WriteLine(rectangle1.GetColor());
        Console.WriteLine(rectangle1.GetArea());

        Circle circle1 = new("orange", 10);
        Console.WriteLine(circle1.GetColor() + " " + circle1.GetArea());
        // Console.WriteLine(circle1.GetArea());


        Console.WriteLine();


        List<Shape> shapes = new();
        shapes.Add(square1);
        shapes.Add(rectangle1);
        shapes.Add(circle1);
        shapes.Add(new Square("forrest green", 6));
        shapes.Add(new Rectangle("sky blue", 2, 7));
        shapes.Add(new Circle("yellow", 9));

        foreach(Shape s in shapes)
        {
            string color = s.GetColor();
            double area = s.GetArea();
            Console.WriteLine($"The {color} shape has an area of {area}.");
        }
    }
}