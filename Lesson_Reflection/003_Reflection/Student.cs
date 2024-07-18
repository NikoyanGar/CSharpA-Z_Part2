namespace _003_Reflection
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }

        [Ignore]
        public string Fullname => $"{Name} {Surname}";
    }
}
