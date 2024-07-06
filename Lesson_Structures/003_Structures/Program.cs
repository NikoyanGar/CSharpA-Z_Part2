namespace _003_Structures
{
    class Program
    {
        static void Main(string[] args)
        {
            //MyStruct ms = new MyStruct();
            var ms = new MyStruct(10);
            //ms.field = 10;
            Console.WriteLine(ms.field); // Can Use.

            Console.ReadLine();
        }
    }

    struct MyStruct
    {
        //Can't use default constructor.when c# version less then 11 
        public MyStruct()
        { }

        public MyStruct(int value)
        {
            this.field = value;
            field1 = 0;
        }

        public int field;
        public int field1;
    }
}
