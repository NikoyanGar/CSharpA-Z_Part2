namespace _005_Interfaces_CSharp8Features
{
    //I see as a pro that you can add new functionality to the interface without
    //breaking compatibility with the older versions of those interfaces
    //but It should be used carefully.
    //Otherwise, it can easily lead to violating the single responsibility principles
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            IWriteLine writeLine = new ConsoleWriter();
            writeLine.WriteLine();

        }
    }
    interface IWriteLine
    {
        public void WriteLine()
        {
            Console.WriteLine("Wow C# 8!");
        }
    }
    public class ConsoleWriter : IWriteLine
    {

    }
}
