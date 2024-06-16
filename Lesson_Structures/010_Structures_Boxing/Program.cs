namespace _010_Structures_Boxing
{
    class Program
    {
        static void Main(string[] args)
        {
            IEquatable<MyStruct> equatable = new MyStruct
            {
                Field = 10
            };
        }
    }

    struct MyStruct : IEquatable<MyStruct>
    {
        public int Field { get; set; }

        public bool Equals(MyStruct other)
        {
            return Field == other.Field;
        }
    }
}
