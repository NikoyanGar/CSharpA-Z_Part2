namespace _005_ICloneable
{
    public class Birthplace
    {
        public Birthplace(string city, string country)
        {
            City = city;
            Country = country;
        }

        public string City { get; set; }
        public string Country { get; set; }
    }
}