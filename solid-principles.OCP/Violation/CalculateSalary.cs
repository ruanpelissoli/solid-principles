namespace solid_principles.OCP.Violation
{
    public class CalculateSalary
    {
        public decimal Calculate(decimal baseSalary, Level level)
        {
            if (level == Level.Trainee)
            {
                return baseSalary * 1.2m;
            }
            else
            {
                return baseSalary * 1.8m;
            }
        }
    }
}
