namespace _005_Inheritance
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

            Teacher t = new Teacher
            {
                name = "T1",
                surname = "T1yan",
                email = "t1@gmail.com",
                salary = 25000
            };

            Print(st);
            Console.WriteLine();
            Print(t);

            Console.ReadLine();
        }

        static void Print(Student st)
        {
            Console.WriteLine("****** Student ******");
            Console.WriteLine(st.FullName);
            Console.WriteLine($"email: {st.email}");
        }

        static void Print(Teacher t)
        {
            Console.WriteLine("****** Teacher ******");
            Console.WriteLine(t.FullName);
            Console.WriteLine($"email: {t.email}");
        }

    }
}
