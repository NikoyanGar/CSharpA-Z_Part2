namespace _001_Covariance
{
    public class MusicAlbum : IMediaItem
    {
        public string Title { get; }
        public string Artist { get; }

        public MusicAlbum(string title, string artist)
        {
            Title = title;
            Artist = artist;
        }
    }
}
