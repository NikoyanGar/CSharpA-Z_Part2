namespace _006_Abstract_Classes
{
    class FullTimeEmployee : BaseEmployeeClass
    {
        public int AnnualSalary { get; set; }
        public override int GetMonthlySalary()
        {
            return this.AnnualSalary / 12;
        }
    }
}
