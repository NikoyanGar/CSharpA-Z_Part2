namespace _002_Ref_Parameters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string name = "Alice";
            //Console.WriteLine("Before UpdateName: " + name);
            //UpdateName(ref name);
            //Console.WriteLine("After UpdateName: " + name);

            Person person = new Person("Bob", 25);

            Console.WriteLine("Before UpdatePerson: " + person.Name + ", " + person.Age);
            UpdatePerson(person);
            Console.WriteLine("After UpdatePerson: " + person.Name + ", " + person.Age);
        }

        static void UpdateName(ref string name)
        {
            name = "John";
        }

        static void UpdatePerson(ref Person person)
        {
            person.Name = "John";
            person.Age = 30;
        }

        static void UpdatePerson(Person person)
        {
            person.Name = "John";
            person.Age = 30;
        }
    }
}
