using solid_principles.OCP.Solution;
using System;
using System.Collections.Generic;

namespace solid_principles.OCP
{
    class Program
    {
        static void Main(string[] args)
        {
            var baseSalary = 1500m;

            var salaryCalculations = new List<CalculateSalary>
            {
                new CalculateTraineeSalary(),
                new CalculateJuniorSalary(),
                new CalculateSeniorSalary()
            };

            foreach (var salaryCalculator in salaryCalculations)
            {
                Console.WriteLine(salaryCalculator.Calculate(baseSalary));
            }
            Console.ReadLine();
        }
    }
}
