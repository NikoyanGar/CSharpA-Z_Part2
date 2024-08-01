using System.Collections;

namespace _006_IEnumerable
{

    namespace _006_IEnumerable
    {
        class CityGuideNotGeneric
        {
            private Attraction[] attractions =
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

            //public IEnumerator GetEnumerator()
            //{
            //    return new AttractionEnumerator(attractions);
            //}
            public IEnumerator GetEnumerator()
            {
                return new AttractionEnumerator1();
            }
        }

        class AttractionEnumerator : IEnumerator
        {
            private Attraction[] attractions;
            private int currentIndex;

            public AttractionEnumerator(Attraction[] attractions)
            {
                this.attractions = attractions;
                currentIndex = -1;
            }

            public object Current
            {
                get
                {
                    return attractions[currentIndex];
                }
            }

            public bool MoveNext()
            {
                currentIndex++;
                return currentIndex < attractions.Length;
            }

            public void Reset()
            {
                currentIndex = -1;
            }
        }
        class AttractionEnumerator1 : IEnumerator
        {
            private Attraction[] attractions =
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

            private int currentIndex;

            public AttractionEnumerator1()
            {
                currentIndex = -1;
            }

            public object Current
            {
                get
                {
                    return attractions[currentIndex];
                }
            }

            public bool MoveNext()
            {
                currentIndex++;
                return currentIndex < attractions.Length;
            }

            public void Reset()
            {
                currentIndex = -1;
            }
        }
    }
}