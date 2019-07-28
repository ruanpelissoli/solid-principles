namespace solid_principles.OCP.Solution
{
    public class CalculateJuniorSalary : CalculateSalary
    {
        public override decimal Calculate(decimal baseSalary)
        {
            return baseSalary * 1.8m;
        }
    }
}
