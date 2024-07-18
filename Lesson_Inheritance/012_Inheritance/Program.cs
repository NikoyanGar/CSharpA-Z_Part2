namespace _012_Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //chnange to object and instead of ovveride declare as new
            Student st = new Student { name = "A1", surname = "A1yan" };

            string str = st.ToString();

            Console.WriteLine(st);
            Console.ReadLine();

        }
    }
}
