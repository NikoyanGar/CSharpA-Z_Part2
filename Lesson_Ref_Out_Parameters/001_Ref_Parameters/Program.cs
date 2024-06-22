namespace _001_Ref_Parameters
{
    //ref and out parameters provide ways to pass variables by reference to methods, allowing them to modify the original values
    //Remember that ref parameters require the variable to be initialized before passing it to the method, while out parameters don't.
    internal class Program
    {
        static void Main(string[] args)
        {
            int number1 = 10;
            Console.WriteLine("Before: " + number1);
            ModifyNumber(number1);
            Console.WriteLine("After: " + number1);

            int number = 10;
            Console.WriteLine("Before: " + number);
            ModifyNumber(ref number);
            Console.WriteLine("After: " + number);
        }

        static void ModifyNumber(int num)
        {
            ++num;
        }

        static void ModifyNumber(ref int num)
        {
            ++num;
        }
        static void ModifyNumber(int num, ref int num1)
        {
            ++num;
            ++num1;
        }

        static void ModifyNumber(ref int num, ref int num1, ref int num2, int num3)
        {
        }
    }
}
