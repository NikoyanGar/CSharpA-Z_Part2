namespace MaxOfTwo
{
    public class Human : IComparable<Human>
    {
        public int Age { get; set; }

        public int CompareTo(Human? other)
        {
            if (other is null) return 1;
            return Age.CompareTo(other.Age);
        }
    }
}