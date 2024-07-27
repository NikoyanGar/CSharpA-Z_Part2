namespace _001_Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
    //default is internal
    interface IInterface//declared directly within a namespace can be public or internal
    {
        //default is public
        void IMethod();
        private interface IInterface//nested case
        {
        }
    }
}
