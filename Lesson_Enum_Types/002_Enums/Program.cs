namespace _002_Enums
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create an array of Student objects
            Student[] students = new Student[]
            {
                    new Student { Name = "John", Age = 20, Gender = Gender.Male },
                    new Student { Name = "Jane", Age = 22, Gender = Gender.Female },
                    new Student { Name = "Alex", Age = 21, Gender = Gender.Male },
                    //new Student { Name = "SomeOther", Age = 21, Gender = Gender.SomeOtherGender },
            };

            // Print the details of each student
            foreach (var student in students)
            {
                student.Print();
            }
        }
    }

    struct Student
    {
        public int Age { get; set; }
        public string Name { get; set; }
        public Gender Gender { get; set; }

        public void Print()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}, Gender: {Gender}");
        }
    }
}
