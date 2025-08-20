using System.Threading;

namespace _001_DateTime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1.1. Local Time
            DateTime localTime = DateTime.Now;
            Console.WriteLine($"Local Time: {localTime} (Kind: {localTime.Kind})");

            // 1.2. UTC (Coordinated Universal Time)
            DateTime utcTime = DateTime.UtcNow;
            Console.WriteLine($"UTC Time: {utcTime} (Kind: {utcTime.Kind})");

            // 1.3. Offset (Смещение)
            DateTimeOffset offsetTime = DateTimeOffset.Now;
            Console.WriteLine($"Offset Time: {offsetTime} (Offset: {offsetTime.Offset})");

            // 1.4. DST (Daylight Saving Time)
            bool isDst = TimeZoneInfo.Local.IsDaylightSavingTime(localTime);
            Console.WriteLine($"Is Daylight Saving Time: {isDst}");


            var utcNow = DateTime.UtcNow; // Kind = Utc
            var localNow = DateTime.Now;  // Kind = Local
            var unspecified = DateTime.SpecifyKind(DateTime.Now, DateTimeKind.Unspecified);


            var local = DateTime.Now; // Local
            var toUtc = local.ToUniversalTime();
            Console.WriteLine($"{local} -> {toUtc}");
            // Переведёт в UTC с учётом TimeZoneInfo.Local

            //var unspecified = DateTime.SpecifyKind(local, DateTimeKind.Unspecified);
            //var toUtcWrong = unspecified.ToUniversalTime();
            //Console.WriteLine($"{unspecified} -> {toUtcWrong}");
        }
    }
}
