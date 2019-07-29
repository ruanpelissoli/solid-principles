using System;

namespace solid_principles.OCP.Solution
{
    public class CalculateSalaryFactory
    {
        public CalculateSalary Create(Level level)
        {
            switch(level)
            {
                case Level.Trainee:
                    return new CalculateTraineeSalary();
                case Level.Junior:
                    return new CalculateJuniorSalary();
                case Level.Senior:
                    return new CalculateSeniorSalary();
                default:
                    throw new ArgumentException("Nível não encontrado.");
            }
        }
    }
}
