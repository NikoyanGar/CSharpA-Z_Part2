namespace _005_Abstract_Classes
{
    public class BaseEmployeeClass
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string GetFullName()
        {
            return this.FirstName + " " + LastName;
        }

        public virtual int GetMonthlySalary()//comment this, and add to concrate classes
        {
            throw new NotImplementedException();
        }
    }
}