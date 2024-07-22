namespace _004_Abstract_Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FullTimeEmployee fte = new FullTimeEmployee();
            {
                fte.ID = 101;
                fte.FirstName = "FirstName";
                fte.FirstName = "FirstName";
                fte.AnnualSalary = 60000;

            };
            Console.WriteLine(fte.GetFullName());
            Console.WriteLine(fte.GetMonthlySalary());
            Console.WriteLine("--------------");



            ContractEmployee cte = new ContractEmployee();
            {
                cte.ID = 101;
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
