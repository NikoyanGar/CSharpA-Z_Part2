﻿namespace _006_Structures
{
    class Program
    {
        static void Main(string[] args)
        {
            var ms = new MyStruct { field = 20 }; //new MyStruct(20);
            Console.WriteLine(ms.field);
            //MyStruct.a = 10;
            Console.ReadLine();
        }
    }

    struct MyStruct
    {
        static MyStruct()//int value parameter is not allowed
        {
            Console.WriteLine("Static Constructor.");
        }

        public MyStruct(int value)
        {
            Console.WriteLine("Constructor");
            this.field = value;
        }

        public int field;
        public static int a;
    }
}
