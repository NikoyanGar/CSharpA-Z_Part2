namespace _002_Ref_Parameters
{
    internal class Person
    {
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public string Name { get; internal set; }
        public int Age { get; internal set; }
    }
}