namespace _008_ValueVsReference
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person { Name = "Alice" };
            Person person2 = person1;

            Person person3 = new Person { Name = "Alice" };
            Person person4 = new Person { Name = "Alice" };

            Console.WriteLine(person1.Equals(person2));
            Console.WriteLine(person1.Equals(person3));
            Console.WriteLine(person1.Equals(person4));

            Console.WriteLine(person1 == person2);
            Console.WriteLine(person1 == person3);
        }
    }
    class Person
    {
        public string Name { get; set; }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            Person otherPerson = (Person)obj;
            return Name == otherPerson.Name;
        }

        public override int GetHashCode()
        {
            return Name.GetHashCode();
        }

        //public static bool operator ==(Person person1, Person person2)
        //{
        //    if (ReferenceEquals(person1, person2))
        //    {
        //        return true;
        //    }

        //    if (ReferenceEquals(person1, null) || ReferenceEquals(person2, null))
        //    {
        //        return false;
        //    }

        //    return person1.Equals(person2);
        //}

        //public static bool operator !=(Person person1, Person person2)
        //{
        //    return !(person1 == person2);
        //}
    }
}

