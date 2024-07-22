namespace _005_Abstract_Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BaseEmployeeClass bec = new BaseEmployeeClass();
            {
                bec.ID = 101;
                bec.FirstName = "FirstName";
                bec.LastName = "LastName";
            };
            Console.WriteLine(bec.GetFullName());
            Console.WriteLine(bec.GetMonthlySalary());//run time error

            FullTimeEmployee fte = new FullTimeEmployee();
            {
                fte.ID = 102;
                fte.FirstName = "FullTimeFirstName";
                fte.LastName = "FullTimeLastName";
                fte.AnnualSalary = 60000;

            };
            Console.WriteLine(fte.GetFullName());
            Console.WriteLine(fte.GetMonthlySalary());
            Console.WriteLine("--------------");

            ContractEmployee cte = new ContractEmployee();
            {
                cte.ID = 103;
                cte.FirstName = "ContractFirstName";
                cte.LastName = "ContractLastName";
                cte.HourlyPay = 200;
                cte.TotalHours = 40;

            };
            Console.WriteLine(cte.GetFullName());
            Console.WriteLine(cte.GetMonthlySalary());
        }
    }
}
