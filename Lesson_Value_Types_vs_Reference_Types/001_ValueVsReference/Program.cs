namespace _001_ValueVsReference
{
    //Example 1: Assigning Value Types. Value types are stored in the stack
    internal class Program
    {
        static void Main(string[] args)
        {
            // Integer assignment
            int x = 10;
            int y = x; // y gets the value of x (10)

            // Floating-point assignment
            double pi = 3.14159;
            double approxPi = pi; // approxPi gets the value of pi (3.14159)

            // Character assignment
            char firstLetter = 'A';
            char lastLetter = firstLetter; // lastLetter gets the value of firstLetter ('A')


            Days today = Days.Thursday;
            Days tomorrow = today; // tomorrow gets the value of today (Days.Thursday)
        }
    }

    // Enum assignment
    enum Days { Sunday, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday }
}

