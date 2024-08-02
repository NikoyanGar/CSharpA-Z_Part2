namespace _001_Covariance
{
    //Covariance(Read-Only Operations)
    //This is because the compiler cannot guarantee that the methods in IMediaItemRepository<T> will only return instances of T (in this case, Book).
    //Without covariance, the compiler requires an exact match between the type arguments of the interface and the implementing class.
    public interface IMediaItemRepository<out T>
    {
        IEnumerable<T> GetAllItems();
    }

    public class BookRepository : IMediaItemRepository<Book>
    {
        public IEnumerable<Book> GetAllItems()
        {
            throw new NotImplementedException();
        }
    }
    public class MovieRepository : IMediaItemRepository<Movie>
    {
        public IEnumerable<Movie> GetAllItems()
        {
            throw new NotImplementedException();
        }
    }
    public class AlbumRepository : IMediaItemRepository<MusicAlbum>
    {
        public IEnumerable<MusicAlbum> GetAllItems()
        {
            throw new NotImplementedException();
        }
    }
}
