namespace _004_IEnumerable
{
    class Attraction
    {
        public Attraction(int uniqueIdentity, string name, string description, string category, int latitude, int longitude)
        {
            Name = name;
            Description = description;
            Category = category;
            Latitude = latitude;
            Longitude = longitude;
            UniqueIdentity = uniqueIdentity;
        }
        public int UniqueIdentity { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public int Latitude { get; set; }
        public int Longitude { get; set; }
    }
}
