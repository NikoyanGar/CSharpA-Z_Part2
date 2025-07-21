namespace BoxWithAllTypesOfValues
{
    internal class Box
    {
        public object Value { get; set; }

        public Box(object value) { Value = value; }

        public void Print() => Console.WriteLine(Value);
    }
    internal class Box<T>
    {
        public T Value { get; }

        public Box(T value) { Value = value; }

        public void Print() => Console.WriteLine(Value);

    }
}
