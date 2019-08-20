using solid_principles.LSP.Solution.New;
using solid_principles.LSP.Solution;
// using solid_principles.LSP.Violation;
using System;
using System.Collections.Generic;

namespace solid_principles.LSP
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape square = new Square(5, 5);
            Console.WriteLine(square.CalculateArea());

            Shape rectangle = new Rectangle(4, 5);
            Console.WriteLine(rectangle.CalculateArea());

            //var employees = new List<Employee>();

            //foreach (var employee in employees)
            //{
            //    if (employee == null)
            //    {
            //        Console.WriteLine("Employee not found.");
            //        continue;
            //    }                    

            //    Helpers.PrintEmployee(employee);
            //}            
        }
    }
}
