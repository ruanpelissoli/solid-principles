using System;

namespace solid_principles.ISP.Violation
{
    public class MultifuncionPrinter : IPrinter
    {
        public void Print()
        {
            Console.WriteLine("Print");
        }

        public void Scanner()
        {
            Console.WriteLine("Scanner");
        }

        public void SendFax()
        {
            Console.WriteLine("Send Fax");
        }
    }
}
