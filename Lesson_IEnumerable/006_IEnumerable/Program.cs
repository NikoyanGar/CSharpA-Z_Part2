using _006_IEnumerable._006_IEnumerable;

namespace _006_IEnumerable
{
    //Iplement the GetNearestAttractionExceptAlreadyBeen method in the CityGuide class that returns the nearest attraction to the user's current location that the user has not already visited.
    //problem : I must implement some logic for iterating and save the visited attractions, not encapsulating all simple logic to visit attractions
    internal class Program
    {
        static void Main(string[] args)
        {
            CityGuideNotGeneric cityGuide = new CityGuideNotGeneric();
            foreach (var attraction in cityGuide)
            {
                Attraction currentAttraction = (Attraction)attraction;
                Console.WriteLine(currentAttraction.Name);
            }
            //IEnumerable cityGuide1 = new CityGuideNotGeneric();
            //foreach (var attraction in cityGuide1)
            //{
            //    Attraction currentAttraction = (Attraction)attraction;
            //    Console.WriteLine(currentAttraction.Name);
            //}

        }

    }
}
