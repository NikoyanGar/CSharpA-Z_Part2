namespace _003_IEnumerable
{
    //Iplement the GetNearestAttractionExceptAlreadyBeen method in the CityGuide class that returns the nearest attraction to the user's current location that the user has not already visited.
    //problem : I must implement some logic for iterating and save the visited attractions, not encapsulating all simple logic to visit attractions
    internal class Program
    {
        static void Main(string[] args)
        {
            int userWantsToSeeAllAttractions = 10;
            Console.WriteLine("Welcome to the City Guide!");

            // Get user's current coordinates
            int userLongitude = GetUserCoordinate("longitude");
            int userLatitude = GetUserCoordinate("latitude");

            // Display all attractions
            Attraction[] attractionsAlreadyBeen = new Attraction[userWantsToSeeAllAttractions];
            for (int i = 0; i < userWantsToSeeAllAttractions; i++)
            {
                var attraction = CityGuide.GetNearestAttractionExceptAlreadyBeen(userLongitude, userLatitude, attractionsAlreadyBeen);
                if (attraction == null)
                {
                    Console.WriteLine();
                    Console.WriteLine("No more attractions to show.");
                    break;
                }
                Console.WriteLine();
                Console.WriteLine($"go to attraction : {attraction.Name}");
                userLatitude = attraction.Latitude;
                userLongitude = attraction.Longitude;
                attractionsAlreadyBeen[i] = attraction;
            }

        }

        static int GetUserCoordinate(string coordinateType)
        {
            Console.Write($"Enter your {coordinateType}: ");
            return int.Parse(Console.ReadLine());
        }
    }
}
