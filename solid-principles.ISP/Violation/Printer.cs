using System;

namespace solid_principles.ISP.Violation
{
    public class Printer : IPrinter
    {
        public void Print()
        {
            Console.WriteLine("Print");
        }

        public void Scanner()
        {
            throw new NotImplementedException();
        }

        public void SendFax()
        {
            throw new NotImplementedException();
        }
    }
}
