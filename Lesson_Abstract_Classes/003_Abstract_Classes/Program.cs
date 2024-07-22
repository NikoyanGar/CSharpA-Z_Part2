namespace _003_Abstract_Classes
{
    // Abstract class representing a shape
    abstract class Shape
    {
        // Abstract methods to calculate area and perimeter
        public abstract double CalculateArea();
        public abstract double CalculatePerimeter();
    }

    // Derived class for a Circle
    class Circle : Shape
    {
        public double Radius { get; set; }

        public override double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }

        public override double CalculatePerimeter()
        {
            return 2 * Math.PI * Radius;
        }
    }

    // Derived class for a Rectangle
    class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public override double CalculateArea()
        {
            return Width * Height;
        }

        public override double CalculatePerimeter()
        {
            return 2 * (Width + Height);
        }
    }

    // Derived class for a Triangle
    class Triangle : Shape
    {
        public double Side1 { get; set; }
        public double Side2 { get; set; }
        public double Side3 { get; set; }

        public override double CalculateArea()
        {
            // Implementing the area calculation using Heron's formula
            double s = (Side1 + Side2 + Side3) / 2;
            return Math.Sqrt(s * (s - Side1) * (s - Side2) * (s - Side3));
        }

        public override double CalculatePerimeter()
        {
            return Side1 + Side2 + Side3;
        }
    }

    // In the main program, we can create instances of these classes and utilize their functionalities.

    class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle { Radius = 5 };
            Rectangle rectangle = new Rectangle { Width = 6, Height = 4 };
            Triangle triangle = new Triangle { Side1 = 3, Side2 = 4, Side3 = 5 };

            Console.WriteLine("Circle Area: " + circle.CalculateArea());
            Console.WriteLine("Circle Perimeter: " + circle.CalculatePerimeter());

            Console.WriteLine("Rectangle Area: " + rectangle.CalculateArea());
            Console.WriteLine("Rectangle Perimeter: " + rectangle.CalculatePerimeter());

            Console.WriteLine("Triangle Area: " + triangle.CalculateArea());
            Console.WriteLine("Triangle Perimeter: " + triangle.CalculatePerimeter());

            Console.ReadKey();
        }
    }
}
