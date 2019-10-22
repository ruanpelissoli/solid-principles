using System;

namespace solid_principles.ISP.Solution
{
    public class Pinter : IPrinter
    {
        public void Print()
        {
            Console.WriteLine("Print");
        }
    }
}
