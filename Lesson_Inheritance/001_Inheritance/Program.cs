namespace _001_Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //BaseClass baseClass = new BaseClass();
            ChildClass childClass = new ChildClass();
            childClass.Name = "Test";
            childClass.SurName = "Test1";
            Console.WriteLine(childClass.Name);
        }
    }
}
