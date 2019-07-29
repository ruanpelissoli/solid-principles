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

            //var calculateSalaryFactory = new CalculateSalaryFactory();

            //var traineeSalary = calculateSalaryFactory.Create(Level.Trainee);
            //Console.WriteLine(traineeSalary.Calculate(baseSalary));

            //var juniorSalary = calculateSalaryFactory.Create(Level.Junior);
            //Console.WriteLine(juniorSalary.Calculate(baseSalary));

            //var seniorSalary = calculateSalaryFactory.Create(Level.Senior);
            //Console.WriteLine(seniorSalary.Calculate(baseSalary));

            //Console.ReadLine();
        }
    }
}
