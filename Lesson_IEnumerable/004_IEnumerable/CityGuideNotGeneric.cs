using System.Collections;

namespace _004_IEnumerable
{
    class CityGuideNotGeneric : IEnumerable
    {
        private static Attraction[] attractions =
        {
                new Attraction(0,"name0", "decs0", "category0", 0, 0),
                new Attraction(1,"Metropolitan Museum of Art", "World-class art collection", "Museum", 1, 0),
                new Attraction(2,"Times Square", "Iconic entertainment hub", "Landmark", 2, 0),
                new Attraction(3,"Statue of Liberty", "Symbol of freedom and democracy", "Landmark", 3, 0),
                new Attraction(4,"Empire State Building", "Iconic skyscraper with stunning views", "Landmark", 0, 1),
                new Attraction(5,"Brooklyn Bridge", "Historic suspension bridge", "Landmark", 0, 2),
                new Attraction(6,"Museum of Modern Art", "Contemporary art museum", "Museum", 0, 3),
                new Attraction(7,"High Line", "Elevated park on a historic freight rail line", "Park", 0, 4),
                new Attraction(8,"Broadway", "World-famous theater district", "Landmark", 0, 5)
            };

        public static Attraction? GetNearestAttractionExceptAlreadyBeen(double longitude, double latitude, Attraction[] alreadyVisitedAttractions)
        {
            Attraction nearestAttraction = null;
            double shortestDistance = double.MaxValue;

            foreach (var attraction in attractions)
            {
                if (!alreadyVisitedAttractions.Contains(attraction))
                {
                    double distance = Math.Sqrt(Math.Pow(attraction.Longitude - longitude, 2) + Math.Pow(attraction.Latitude - latitude, 2));

                    if (distance < shortestDistance)
                    {
                        shortestDistance = distance;
                        nearestAttraction = attraction;
                    }
                }
            }

            return nearestAttraction;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return attractions.GetEnumerator();
        }
    }
}
