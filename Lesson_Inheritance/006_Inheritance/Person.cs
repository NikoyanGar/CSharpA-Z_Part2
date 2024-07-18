namespace _006_Inheritance
{
    class Person
    {
        public string name;
        public string surname;
        public string email;

        public string FullName => $"{surname} {name}";

        //public string FullName
        //{
        //    get { return $"{surname} {name}"; }
        //}

    }
}
