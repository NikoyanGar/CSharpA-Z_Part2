namespace _004_Partial_Classes
{
    public partial class MyCalc : IAddition
    {
        public decimal Add(decimal operand1, decimal operand2)
        {
            return operand1 + operand2;
        }


    }
    public partial class MyCalc : ISubstraction
    {
        public decimal Substract(decimal operand1, decimal operand2)
        {
            return operand1 - operand2;
        }
    }
}
