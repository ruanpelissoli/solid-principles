using System;

namespace solid_principles.OCP.Violation
{
    public class CalculateSalary
    {
        public decimal Calculate(decimal baseSalary, Level level)
        {
            switch(level)
            {
                case Level.Trainee:
                    return baseSalary * 1.2m;
                case Level.Junior:
                    return baseSalary * 1.8m;
                default:
                    throw new ArgumentException("Nível não encontrado.");
            }
        }
    }
}
