namespace _001_Covariance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IMediaItemRepository<IMediaItem> repository = new BookRepository();
            var allBooks = repository.GetAllItems(); // Covariant behavior

        }
    }
}
