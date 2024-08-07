﻿namespace _004_Generics
{
    class Program
    {
        static void Main()
        {
            Rectangle rectangle = new Rectangle();

            IContainer<Rectangle> container = new Container<Rectangle>(rectangle);

            Console.WriteLine(container.Figure.ToString());

            // Delay.
            Console.ReadKey();
        }
    }

    public abstract class Shape { }
    public class Rectangle : Shape { }

    public interface IContainer<T>
    {
        T Figure { get; set; }
    }

    public class Container<T> : IContainer<T>
    {
        public T Figure { get; set; }

        public Container(T figure)
        {
            this.Figure = figure;
        }
    }
}
