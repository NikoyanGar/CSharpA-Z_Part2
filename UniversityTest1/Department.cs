
namespace UniversityTest1
{
    internal class Department
    {
        public Department(
            string name,
            string location,
            int capacity,
            List<string> courses,
            List<string> faculty)
        {
            Name = name;
            Location = location;
            Capacity = capacity;
            Courses = courses;
            Faculty = faculty;
        }

        public string Name { get; set; }
        public string Location { get; set; }
        public int Capacity { get; set; }
        public List<string> Courses { get; set; }
        public List<string> Faculty { get; set; }

        private List<Student> Students = new List<Student>();

        internal void AddStudent(Student student1)
        {
            //TODO: Add check functionality for department
            Students.Add(student1);
        }

        public override bool Equals(object? obj)
        {
            return obj is Department department &&
                   Name == department.Name &&
                   Location == department.Location &&
                   Capacity == department.Capacity &&
                   EqualityComparer<List<string>>.Default.Equals(Courses, department.Courses) &&
                   EqualityComparer<List<string>>.Default.Equals(Faculty, department.Faculty);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Name, Location, Capacity, Courses, Faculty);
        }
    }
}