namespace _005_Inheritance
{
    class Student
    {
        public string name;
        public string surname;
        public string email;

        public string FullName => $"{surname} {name}";
        //{
        //    get { return $"{surname} {name}"; }
        //}

        public string faculty;
    }

}
