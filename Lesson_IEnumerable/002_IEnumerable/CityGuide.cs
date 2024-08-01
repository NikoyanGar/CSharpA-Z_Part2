namespace _002_IEnumerable
{
    class CityGuide
    {
        private static List<Attraction> attractions = new List<Attraction>
                {
                    new Attraction { Name = "Central Park", Description = "Beautiful green space in NYC", Category = "Park" },
                    new Attraction { Name = "Metropolitan Museum of Art", Description = "World-class art collection", Category = "Museum" },
                    new Attraction { Name = "Times Square", Description = "Iconic entertainment hub", Category = "Landmark" },
                    new Attraction { Name = "Statue of Liberty", Description = "Symbol of freedom and democracy", Category = "Landmark" },
                    new Attraction { Name = "Empire State Building", Description = "Iconic skyscraper with stunning views", Category = "Landmark" },
                    new Attraction { Name = "Brooklyn Bridge", Description = "Historic suspension bridge", Category = "Landmark" },
                    new Attraction { Name = "Museum of Modern Art", Description = "Contemporary art museum", Category = "Museum" },
                    new Attraction { Name = "High Line", Description = "Elevated park on a historic freight rail line", Category = "Park" },
                    new Attraction { Name = "Broadway", Description = "World-famous theater district", Category = "Landmark" }
                };

        public static void DisplayAllAttractions()
        {
            Console.WriteLine("\nAll Attractions:");

            for (int i = 0; i < attractions.Count; i++)
            {
                var attraction = attractions[i];
                Console.WriteLine($"{attraction.Name} ({attraction.Category}): {attraction.Description}");
            }
        }
    }
}
