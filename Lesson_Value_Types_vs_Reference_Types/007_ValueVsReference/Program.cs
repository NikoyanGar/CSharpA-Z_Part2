namespace _007_ValueVsReference
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person { Name = "Alice" };
            Person person2 = person1;

            Person person3 = new Person { Name = "Alice" };
            Person person4 = new Person { Name = "Alice" };

            bool isEqual1 = person1 == person2; // true, since both variables refer to the same object
            bool isEqual2 = person1 == person3; // false, even though the properties are the same, they refer to different objects
            bool isEqual3 = person3 == person4; // false, since they refer to two different objects with different memory addresses

        }
    }
    class Person
    {
        public string Name { get; set; }
    }
}
