using _007_Inheritance;

namespace _008_Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student st = new Student
            {
                name = "A1",
                surname = "A1yan",
                email = "a1@gmail.com",
                faculty = "faculty"
            };

            object obj = st;

            int a = 1;
            object obj1 = a;

        }
    }
}
