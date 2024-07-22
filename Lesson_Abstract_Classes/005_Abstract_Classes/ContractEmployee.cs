namespace _005_Abstract_Classes
{
    public class ContractEmployee : BaseEmployeeClass
    {
        public int HourlyPay { get; set; }
        public int TotalHours { get; set; }

        public int GetMonthlySalary()
        {
            return this.TotalHours * this.HourlyPay;
        }
    }
}
