﻿namespace _008_Structures_Boxing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 10;

            // Boxing
            object o = a;

            // Unboxing
            int a1 = (int)o;

            long l = a;
            long l1 = (long)(int)o;
            //long l2 = (int)o;

            Console.ReadLine();
        }
    }
}
