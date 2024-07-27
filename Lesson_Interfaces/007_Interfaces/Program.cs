namespace _007_Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyList myList = new MyList();
            IEnumerable enumerable = myList;
            enumerable.GetEnumerator();
            IList list = myList;
            list.Add(1);
            IEnumerable enumerable2 = myList;
            enumerable2.GetEnumerator();
        }
    }
    public class MyList : IList
    {
        public int Add(object value)
        {
            Console.WriteLine("Add method called");
            return 0;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            Console.WriteLine("IEnumerable.GetEnumerator method called");
            return null;
        }
        public IEnumerator GetEnumerator()
        {
            Console.WriteLine("GetEnumerator method called");
            return null;
        }
    }
    public interface IEnumerable
    {
        IEnumerator GetEnumerator();
    }
    public interface IEnumerator
    {

    }
    public interface ICollection : IEnumerable
    {
        int Count { get; }
    }
    public interface IList : IEnumerable
    {
        public int Add(object value);
    }
}
