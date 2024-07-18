namespace _009_Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student st = new Student
            {
                name = "A1",
                surname = "A1yan",
                age = 20,
                city = new City
                {
                    name = "Yerevan"
                }
            };

            //Student st1 = new Student
            //{
            //    name = st.name,
            //    surname = st.surname,
            //    age = st.age
            //};

            Student st1 = st.Clone1();

            if (st.Equals(st1))
            {

            }

            if (st.city.Equals(st1.city))
            {

            }

            Console.ReadLine();

        }
    }
}
