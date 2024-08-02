namespace _001_Covariance
{
    public class Movie : IMediaItem
    {
        public string Title { get; }
        public string Director { get; }

        public Movie(string title, string director)
        {
            Title = title;
            Director = director;
        }
    }
}
