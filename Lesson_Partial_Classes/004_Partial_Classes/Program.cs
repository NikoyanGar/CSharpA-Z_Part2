namespace _004_Partial_Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            MyCalc myCalc = new MyCalc();
            var addresult = myCalc.Add(1, 2);
            var subresult = myCalc.Substract(3, 2);
            Console.WriteLine(addresult);
            Console.WriteLine(subresult);
        }
    }
}

