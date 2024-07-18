namespace _010_Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Point p = new Point { x = 10, y = -25 };
            Print(p);
            //p.PrintPoint();

            Circle ci = new Circle { x = 10, y = -25, R = -25 };
            Print(ci);
            //ci.PrintCircle();

            Cylinder cy = new Cylinder { x = 10, y = -25, R = -25, H = 25 };
            Print(cy);
            //cy.PrintCylinder();

            Console.ReadLine();
        }

        static void Print(Point p)
        {
            string header = $"****** {p.GetType().Name} ******";

            Console.WriteLine();
            Console.WriteLine(header);

            p.Print();

            Console.WriteLine();
            Console.WriteLine(new string('*', header.Length));
        }

        //static void Print(Circle p)
        //{
        //    string header = $"****** {p.GetType().Name} ******";

        //    Console.WriteLine();
        //    Console.WriteLine(header);

        //    p.Print();

        //    Console.WriteLine();
        //    Console.WriteLine(new string('*', header.Length));
        //}

        //static void Print(Cylinder p)
        //{
        //    string header = $"****** {p.GetType().Name} ******";

        //    Console.WriteLine();
        //    Console.WriteLine(header);

        //    p.Print();

        //    Console.WriteLine();
        //    Console.WriteLine(new string('*', header.Length));
        //}
    }
}
