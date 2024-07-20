namespace UniversityTest1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            University university = new University("University of Texas at Dallas");
            university.AddDepartment("Computer Science");
            DepartmentInputModel department1 = new DepartmentInputModel();
            university.AddDepartment(department1);
            StudentInputModel student1 = new StudentInputModel();
            university.AddStudentToDepartment("Computer Science", student1);
        }
    }
}
