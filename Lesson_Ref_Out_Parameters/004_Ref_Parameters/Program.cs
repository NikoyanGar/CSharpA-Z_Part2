namespace _004_Ref_Parameters
{
    //https://learn.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca1045
    //Don't want methods to mutate your references
    internal class Program
    {
        static void Main(string[] args)
        {
            string s1 = "12345";
            string s2 = "12345";
            string s3 = "12345";

            Console.WriteLine("Changing pointer - passed by value:");
            Console.WriteLine("before " + s1);
            BadPassTheObject(s1);
            Console.WriteLine("after  " + s1);

            Console.WriteLine("Changing pointer - passed by reference:");
            Console.WriteLine("before " + s2);
            PassTheReference(ref s2);
            Console.WriteLine("after  " + s2);

            Console.WriteLine("Passing by return value:");
            s3 = BetterThanPassTheReference(s3);
            Console.WriteLine(s3); Console.WriteLine("Hello, World!");
        }

        // The following syntax will not work. You cannot make a
        // reference type that is passed by value point to a new
        // instance. This needs the ref keyword.
        public static void BadPassTheObject(string argument)
        {
            argument = argument + " ABCDE";
        }

        // The following syntax will work, but is considered bad design.
        // It reassigns the argument to point to a new instance of string.
        // Violates rule DoNotPassTypesByReference.
        public static void PassTheReference(ref string argument)
        {
            argument = argument + " ABCDE";
        }

        // The following syntax will work and is a better design.
        // It returns the altered argument as a new instance of string.
        public static string BetterThanPassTheReference(string argument)
        {
            return argument + " ABCDE";
        }
    }
    //Value type without ref - you get a new copy of the original box. You can play with it, change it, but the original stays the same.

    //reference type without ref - you get a copy of the address of the box.Since you know where the box is, everyone can see what you do to it, how you change it. There is no copy of the box, you are changing the same box that everyone else sees.

    //Value type with ref - You get the original box.Since you have the original, everyone can see what you do to it, how you change it. There is no copy of the box.Behavior is essentialy the same as in the 2nd case, just without the indirect step to look at the address first.

    //Reference type with ref - You get the 'main' address of the box. You can do whatever you want with box, just like in the 2nd case. In addition to that, you can change the address to point at another box, or a new box that no one has seen before.This can also mean that it won't be possible to find the old box after you change the address. Because of this, 'ref' keyword is used rarely.
}
