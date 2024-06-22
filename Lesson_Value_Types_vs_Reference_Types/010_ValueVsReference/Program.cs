namespace _010_ValueVsReference
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PersonStruct personStruct = new PersonStruct { Name = "Bob" };
            ModifyPersonName(personStruct);
            Console.WriteLine($"Outside method: person.Name = {personStruct.Name} Without ref ");


            PersonStruct personStruct1 = new PersonStruct { Name = "Bob" };
            ModifyPersonName(ref personStruct1);
            Console.WriteLine($"Outside method: person1.Name = {personStruct1.Name} With ref ");

        }
        //This means that a copy of personStruct is passed to the method. Inside the ModifyPersonName method, the Name property of the copied PersonStruct instance is modified to "Alice". However, this modification does not affect the original personStruct instance. Therefore, when the Console.WriteLine statement is executed, it prints "Bob" because the original personStruct instance was not modified.
        static void ModifyPersonName(ref PersonStruct p)
        {
            p.Name = "Alice";
        }
        //This means that the method receives a reference to the original personStruct1 instance, rather than a copy. Inside the ModifyPersonName method, the Name property of the original personStruct1 instance is modified to "Alice". As a result, when the Console.WriteLine statement is executed, it prints "Alice" because the original personStruct1 instance was modified.
        static void ModifyPersonName(PersonStruct p)
        {
            p.Name = "Alice";
        }
    }
}
