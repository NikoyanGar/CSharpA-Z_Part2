namespace _005_Abstract_Classes
{
    class FullTimeEmployee : BaseEmployeeClass
    {
        public int AnnualSalary { get; set; }
        public int GetMonthlySalary()
        {
            return this.AnnualSalary / 12;
        }
    }
}
