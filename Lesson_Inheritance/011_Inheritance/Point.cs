namespace _011_Inheritance
{
    class Point
    {
        public int x;
        public int y;

        public virtual void Print()
        {
            Console.WriteLine($"({x},{y})");
        }
    }
}
