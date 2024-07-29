using System;

namespace _003_Interface_vs_AbstractClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IWriteLine writeLine = new ConsoleWriter();
            writeLine.WriteLine();
        }
    }
    interface IWriteLine
    {
        public void WriteLine()//Change LangVersion in project file
        {
            Console.WriteLine("Wow C# 8!");
        }
    }
    public class ConsoleWriter : IWriteLine
    {
        void IWriteLine.WriteLine()
        {
            Console.WriteLine("ConsoleWriter");
        }
    }
    public abstract class AbstractWriteLine
    {
        public void WriteLine()
        {
            Console.WriteLine("available in all versions");
        }
    }
}
