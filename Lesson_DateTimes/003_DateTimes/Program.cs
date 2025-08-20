namespace _003_DateTimes
{
    //5.1. Стандарт ISO 8601
    //2025-08-14T15:00:00+04:00 — время с указанием смещения.
    //2025-08-14T11:00:00Z — время в UTC (Z = Zero offset).
    internal class Program
    {
        static void Main(string[] args)
        {
            string iso = DateTimeOffset.Now.ToString("o"); // o = round-trip format
            Console.WriteLine(iso); // 2025-08-14T15:00:00.0000000+04:00
        }
    }
}
