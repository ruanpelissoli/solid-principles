namespace solid_principles.OCP.Solution
{
    public class CalculateTraineeSalary : CalculateSalary
    {
        public override decimal Calculate(decimal baseSalary)
        {
            return baseSalary * 1.2m;
        }
    }
}
