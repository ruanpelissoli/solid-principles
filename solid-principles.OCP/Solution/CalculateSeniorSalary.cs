namespace solid_principles.OCP.Solution
{
    public class CalculateSeniorSalary : CalculateSalary
    {
        public override decimal Calculate(decimal baseSalary)
        {
            return baseSalary * 3m;
        }
    }
}
