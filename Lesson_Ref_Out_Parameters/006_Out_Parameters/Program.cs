namespace _004_Out_Parameters
{
    //As a parameter modifier, which lets you pass an argument to a method by reference rather than by value.
    //In generic type parameter declarations for interfaces and delegates, which specifies that a type parameter is covariant.
    internal class Program
    {
        static void Main(string[] args)
        {
            double radiusValue = 3.92781;
            //Calculate the circumference and area of a circle, returning the results to Main().
            CalculateCircumferenceAndArea(radiusValue, out double circumferenceResult, out var areaResult);

            Console.WriteLine($"Circumference of a circle with a radius of {radiusValue} is {circumferenceResult}.");
            Console.WriteLine($"Are of a circle with a radius of {radiusValue} is {areaResult}.");
            Console.ReadLine();
        }
        //The calculation worker method.                                           длина окружности
        public static void CalculateCircumferenceAndArea(double radius, out double circumference, out double area)
        {
            circumference = 2 * Math.PI * radius;
            area = Math.PI * (radius * radius);
        }
    }
}
