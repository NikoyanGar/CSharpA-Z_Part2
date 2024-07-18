namespace _005_Inheritance
{
    class Teacher
    {
        public string name;
        public string surname;
        public string email;

        public string FullName => $"{surname} {name}";

        public int salary;
    }
}
