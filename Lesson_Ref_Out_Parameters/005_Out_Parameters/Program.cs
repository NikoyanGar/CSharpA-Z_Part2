namespace _005_Out_Parameters
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

            int number;// = 10;
            //Console.WriteLine("Before: " + number);
            ModifyNumber(out number);
            Console.WriteLine("After: " + number);
        }

        static void ModifyNumber(int num)
        {
            ++num;
        }

        static void ModifyNumber(out int num)
        {
            //Console.WriteLine("Before: " + num);
            num = 0;
            ++num;
        }

        static void ModifyNumber(int num, out int num1)
        {
            num1 = 0;
            ++num;
            ++num1;
        }

        static void ModifyNumber(out int num, out int num1, out int num2, int num3)
        {
            num = 0;
            num1 = 0;
            num2 = 0;
        }
    }
}
