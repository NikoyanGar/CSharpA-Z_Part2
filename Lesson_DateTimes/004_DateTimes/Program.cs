using System.Text.Json;

namespace _004_DateTimes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime utcNow = DateTime.UtcNow;
            string json = JsonSerializer.Serialize(utcNow);

            Console.WriteLine($"Serialized: {json}");

            DateTime parsed = JsonSerializer.Deserialize<DateTime>(json);

            Console.WriteLine($"Deserialized: {parsed.ToString("o")} ({parsed.Kind})");

        }
    }
}
