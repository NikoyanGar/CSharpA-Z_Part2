namespace _001_Covariance
{
    public class Book : IMediaItem
    {
        public string Title { get; }
        public string Author { get; }

        public Book(string title, string author)
        {
            Title = title;
            Author = author;
        }
    }
}
