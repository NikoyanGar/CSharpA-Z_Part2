
namespace UniversityTest1
{
    internal class University
    {
        private string Name;

        private List<Department> Departments = new List<Department>();

        public University(string name)
        {
            this.Name = name;
        }

        internal void AddDepartment(string departmentName)
        {
            throw new NotImplementedException();
        }
        internal void AddDepartment(DepartmentInputModel department)
        {
            var dep = new Department(
                department.Name,
                department.Location,
                department.Capacity,
                null,
                null);

            Departments.Add(dep);
        }

        internal void AddStudentToDepartment(string v, StudentInputModel student1)
        {
            throw new NotImplementedException();
        }
        internal void AddStudentToDepartment(
            DepartmentInputModel department,
            StudentInputModel student1)
        {
            //TODO: Add check functionality for department
            Student student = new Student
            {
                Name = student1.Name,
                Age = student1.Age,
                Facultet = student1.Facultet,
                Course = student1.Course
            };
            Students.Add(student);
        }
    }
}