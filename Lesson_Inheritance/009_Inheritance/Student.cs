namespace _009_Inheritance
{
    class Student
    {
        public Student()
        {
            Console.WriteLine("ctor.");
        }

        public string name;
        public string surname;
        public int age;

        public City city;

        public Student Clone1()
        {
            return MemberwiseClone() as Student;
            //object instance = base.MemberwiseClone();
            //Student st = instance as Student;
            //return st;
        }

        public Student Clone()
        {
            return new Student
            {
                name = this.name,
                surname = this.surname,
                age = this.age
            };
        }
    }

    class City
    {
        public string name;
    }

}
