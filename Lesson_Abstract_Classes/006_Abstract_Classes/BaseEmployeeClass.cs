namespace _006_Abstract_Classes
{
    public abstract class BaseEmployeeClass
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string GetFullName()
        {
            return this.FirstName + " " + LastName;
        }

        public abstract int GetMonthlySalary();


    }
}
