namespace _005_Structures
{
    class Program
    {
        static void Main(string[] args)
        {
            //MyStruct.field = 10;
            MyStruct.Show();

            Console.ReadLine();
        }
    }

    /*static*/
    struct MyStruct
    {
        public static int field { get; set; }

        public static void Show()
        {
            Console.WriteLine(field);
        }
    }
}
