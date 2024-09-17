namespace _002_Example01_Disposable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var filePathfullPath = "C:\\Users\\garik.nikoyan\\source\\repos\\CSharpA-Z_Part2\\Lesson_GC\\Disposable\\002_Example01_Disposable\\file.txt";

            //var filePathfullPath1 = @"C:\Users\garik.nikoyan\source\repos\CSharpA-Z_Part2\Lesson_GC\Disposable\002_Example01_Disposable\file.txt";

            using (var file = File.OpenText(filePathfullPath))
            {
                var fileContent = file.ReadToEnd();
            }
            // var fileContent = File.ReadAllText(filePathfullPath);
            // equivalent code
            //var file = File.OpenText(filePathfullPath);
            //try
            //{
            //    var fileContent = file.ReadToEnd();
            //}
            //finally
            //{
            //    file.Dispose();
            //}
        }
    }
}
