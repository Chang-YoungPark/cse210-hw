using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shape = new List<Shape>();
        Square square = new Square("blue", 10);   
        shape.Add(square);

        Rectangle ractangle = new Rectangle("Red", 15, 15);
        shape.Add(ractangle);

        Circle circle = new Circle("Green", 15);
        shape.Add(circle);
        
        foreach (Shape item in shape)
        {
            string color = item.GetColor();

            double size = item.GetArea();

            Console.WriteLine($"The {color} shape has area of {size}. ");
        }


    }
}