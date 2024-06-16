namespace _001_Structures
{
    internal class Program
    {

        static void Main(string[] args)
        {
            //ValueType vt = a;
            MyStruct ms;

            ms.field = 10;

            Console.WriteLine(ms.field);

            Console.ReadLine();
        }

        struct MyStruct
        {
            public int field;
        }

    }
}
