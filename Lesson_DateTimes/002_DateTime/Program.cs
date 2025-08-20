namespace _002_DateTime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // List all system time zones
            Console.WriteLine("All System Time Zones:");
            foreach (var tz in TimeZoneInfo.GetSystemTimeZones())
            {
                Console.WriteLine($"{tz.Id} — {tz.DisplayName}");
            }

            Console.WriteLine("\nLocal Time Zone:");
            var localZone = TimeZoneInfo.Local;
            Console.WriteLine($"Id: {localZone.Id}");
            Console.WriteLine($"DisplayName: {localZone.DisplayName}");
            Console.WriteLine($"BaseUtcOffset: {localZone.BaseUtcOffset}");
            Console.WriteLine($"SupportsDaylightSavingTime: {localZone.SupportsDaylightSavingTime}");

            Console.WriteLine("\nUTC Time Zone:");
            var utcZone = TimeZoneInfo.Utc;
            Console.WriteLine($"Id: {utcZone.Id}");
            Console.WriteLine($"DisplayName: {utcZone.DisplayName}");

            Console.WriteLine("\nConvert Local Time to UTC:");
            DateTime localNow = DateTime.Now;
            DateTime utcNow = TimeZoneInfo.ConvertTimeToUtc(localNow, localZone);
            Console.WriteLine($"Local: {localNow}");
            Console.WriteLine($"UTC:   {utcNow}");

            Console.WriteLine("\nConvert UTC to Another Time Zone (Pacific Standard Time):");
            var pacificZone = TimeZoneInfo.FindSystemTimeZoneById("Pacific Standard Time");
            DateTime pacificTime = TimeZoneInfo.ConvertTimeFromUtc(utcNow, pacificZone);
            Console.WriteLine($"UTC:     {utcNow}");
            Console.WriteLine($"Pacific: {pacificTime}");

            Console.WriteLine("\nCheck if a DateTime is Daylight Saving Time in Local Zone:");
            bool isDst = localZone.IsDaylightSavingTime(localNow);
            Console.WriteLine($"Is DST: {isDst}");

            // var tz1 = TimeZoneInfo.FindSystemTimeZoneById("Asia/Yerevan");

            //1. Ошибка при конвертации Unspecified → UTC
            // Предположим, это время уже в UTC, но мы этого не указали
            DateTime incorrectUtc = new DateTime(2025, 8, 14, 10, 0, 0, DateTimeKind.Unspecified);

            // Конвертация в UTC
            DateTime converted = incorrectUtc.ToUniversalTime();

            Console.WriteLine($"Оригинал: {incorrectUtc} ({incorrectUtc.Kind})");
            Console.WriteLine($"После ToUniversalTime(): {converted} ({converted.Kind})");
            //Что произойдёт:
            //.NET подумает, что это локальное время и отнимет offset.
            //Если локальная зона + 04:00, то время станет 2025 - 08 - 14 06:00:00 UTC, что неверно.
        }
    }
}
