namespace _003_Ref_Parameters
{
    //Using ref on a reference type is actually slightly different to not using it.
    //The difference is that the ref keyword makes it a reference (pointer) to the variable,
    //not just the object. This allows assigning to the source variable of the parameter from within the method.
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, 2, 3 };
            int[] nums1 = { 1, 2, 3 };

            Update(nums);
            UpdateRef(ref nums1);

            Console.WriteLine("nums");
            foreach (var val in nums)
                Console.WriteLine(val);

            Console.WriteLine("nums1");
            foreach (var val in nums1)
                Console.WriteLine(val);
        }

        static void Update(int[] nums)
        {
            nums = new int[] { 4, 5, 6 };
        }

        static void UpdateRef(ref int[] nums)
        {
            nums = new int[] { 4, 5, 6 };
        }
    }
}
