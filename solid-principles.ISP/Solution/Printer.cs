using System;

namespace solid_principles.ISP.Solution
{
    public class Pinter : IPrint
    {
        public void Print()
        {
            Console.WriteLine("Print");
        }
    }
}
