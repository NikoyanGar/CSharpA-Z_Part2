namespace _012_Inheritance
{
    class Student
    {
        public string name;
        public string surname;

        public string FullName => $"{surname} {name}";

        public override string ToString()//change to new
        {
            return FullName;
        }
    }

}
