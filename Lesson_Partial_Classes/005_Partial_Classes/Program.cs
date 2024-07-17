namespace _005_Partial_Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PartialEmployee emp = new PartialEmployee()
            {
                FirstName = "Pranaya",
                LastName = "Rout",
                Salary = 100000,
                Gender = "Male"
            };
            emp.DisplayFullName();
            emp.DisplayEmployeeDetails();
            Console.ReadKey();
        }
    }
}
