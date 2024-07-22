namespace _002_Casting_Rules
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int myInt = 9;
            object myObj = myInt; // Boxing: Implicit casting from int to object

            int myUnboxedInt = (int)myObj; // Unboxing: Explicit casting from object to int

            string myString = "mystr";
            object myObj1 = myString; // Boxing: Implicit casting from string to object
            string myUnboxedString = (string)myObj1; // Unboxing: Explicit casting from object to string

            Console.WriteLine(myUnboxedInt);
        }
    }
}
