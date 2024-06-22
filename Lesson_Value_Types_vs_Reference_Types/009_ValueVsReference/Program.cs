namespace _009_ValueVsReference
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PersonStruct personStruct = new PersonStruct { Name = "Bob" };
            ModifyPersonName(personStruct);
            Console.WriteLine($"Outside method: person.Name = {personStruct.Name}");

            Console.WriteLine("-----------------------------------------------");

            PersonClass person = new PersonClass { Name = "Bob" };
            ModifyPersonName(person);
            Console.WriteLine($"Outside method: person.Name = {person.Name}");

        }

        static void ModifyPersonName(PersonClass p)
        {
            p.Name = "Alice";
        }

        static void ModifyPersonName(PersonStruct p)
        {
            p.Name = "Alice";
        }
    }
}
