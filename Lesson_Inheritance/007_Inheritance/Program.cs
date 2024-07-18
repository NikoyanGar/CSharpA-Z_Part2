namespace _007_Inheritance
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

            Person p1 = st;
            Person p2 = t;

            Print(st);
            Console.WriteLine();
            Print(t);

            Console.ReadLine();
        }

        static void Print(Person p)
        {
            Type t = p.GetType();

            Console.WriteLine($"****** {t.Name} ******");
            Console.WriteLine(p.FullName);
            Console.WriteLine($"email: {p.email}");

            //if(p is Student)
            //{
            //    Student st = (Student)p;
            //    Console.WriteLine($"faculty: {st.faculty}");
            //}

            Student st = p as Student;
            if (st != null)
                Console.WriteLine($"faculty: {st.faculty}");
        }

    }
}
