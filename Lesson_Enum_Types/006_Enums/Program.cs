namespace _006_Enums
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TrafficLight light = TrafficLight.Yellow;

            switch (light)
            {
                case TrafficLight.Red:
                    Console.WriteLine("STOP");
                    break;
                case TrafficLight.Yellow:
                    Console.WriteLine("CAUTION");
                    break;
                case TrafficLight.Green:
                    Console.WriteLine("GO");
                    break;
                default:
                    Console.WriteLine("NONE");//Not working
                    break;
            }
        }
    }
    enum TrafficLight
    {
        Red = 1,
        Yellow = 2,
        Green = 3
    }
}
